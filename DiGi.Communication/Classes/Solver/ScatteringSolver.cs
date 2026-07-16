using DiGi.Communication.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Provides functionality to solve scattering calculations within a communication system,
    /// integrating geometrical propagation models and various scattering profiles on the CPU.
    /// </summary>
    public class ScatteringSolver : ICommunicationObject, ISolver
    {
        private struct CachedFaceInfo
        {
            public PolygonalFace3D Face;
            public BoundingBox3D BBox;
            public string Reference;
            public Triangle3D Triangle;
        }

        private class CachedScatteringGroup
        {
            public BoundingBox3D BoundingBox3D { get; }
            public List<BoundingBox3D> BoundingBox3Ds { get; }
            public CachedFaceInfo[] CachedFaceInfos { get; }

            //Per face 6 doubles: minX, minY, minZ, maxX, maxY, maxZ (tight scan data for the scalar slab test)
            public double[] FaceSlabs { get; }

            //Per face 16 doubles: unit normal (3) + plane offset (1), then 3 x inward edge normal (3) + edge offset (1); NaN normal marks a face requiring the exact test
            public double[] FaceTriangles { get; }

            public double MinX { get; }
            public double MinY { get; }
            public double MinZ { get; }
            public double MaxX { get; }
            public double MaxY { get; }
            public double MaxZ { get; }

            public CachedScatteringGroup(BoundingBox3D boundingBox3D, List<BoundingBox3D> boundingBox3Ds, CachedFaceInfo[] cachedFaceInfos, double[] faceSlabs, double[] faceTriangles)
            {
                BoundingBox3D = boundingBox3D;
                BoundingBox3Ds = boundingBox3Ds;
                CachedFaceInfos = cachedFaceInfos;
                FaceSlabs = faceSlabs;
                FaceTriangles = faceTriangles;

                MinX = boundingBox3D.MinX;
                MinY = boundingBox3D.MinY;
                MinZ = boundingBox3D.MinZ;
                MaxX = boundingBox3D.MaxX;
                MaxY = boundingBox3D.MaxY;
                MaxZ = boundingBox3D.MaxZ;
            }
        }

        private class SegmentComponent
        {
            public string Reference { get; }
            public List<Segment3D> Segments { get; }

            public SegmentComponent(string reference, List<Segment3D> segments)
            {
                Reference = reference;
                Segments = segments;
            }
        }

        private struct CandidatePoint
        {
            public Segment3D SegmentToLoc;
            public Point3D Point;
            public SegmentComponent Component;
        }

        private struct IntersectionSegment
        {
            public Segment3D Segment;
            public string Reference;
        }

        private List<IScatteringProfile>? scatteringProfiles;

        /// <summary>
        /// Gets or sets the geometrical propagation model used by the scattering solver.
        /// </summary>
        public GeometricalPropagationModel? GeometricalPropagationModel { get; set; }

        /// <summary>
        /// Gets or sets the configuration options for the scattering solver.
        /// </summary>
        public ScatteringSolverOptions? ScatteringSolverOptions { get; set; }

        /// <summary>
        /// Gets a cloned list of scattering profiles, filtering out any null entries.
        /// </summary>
        public List<IScatteringProfile>? ScatteringProfiles
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(scatteringProfiles);
            }
        }

        /// <summary>
        /// Executes the solving operation on the CPU.
        /// </summary>
        /// <returns><c>true</c> if the solver successfully executed; otherwise, <c>false</c>.</returns>
        public bool Solve()
        {
            scatteringProfiles = null;

            if (ScatteringSolverOptions == null || GeometricalPropagationModel == null)
            {
                return false;
            }

            List<IMultipathPowerDelayProfile>? multipathPowerDelayProfiles = GeometricalPropagationModel.GetMultipathPowerDelayProfiles<IMultipathPowerDelayProfile>();
            if (multipathPowerDelayProfiles == null || multipathPowerDelayProfiles.Count == 0)
            {
                return false;
            }

            double tolerance = ScatteringSolverOptions.Tolerance;
            double angleFactor = ScatteringSolverOptions.AngleFactor;
            double pointDensityFactor = ScatteringSolverOptions.PointDensityFactor;

            //Safety band for the scalar occlusion fast path; decisions closer to the tolerance than this margin fall back to the exact intersection test
            double margin = tolerance * 10.0;

            List<Tuple<IAntenna, IAntenna, IMultipathPowerDelayProfile>> tuples = [];
            foreach (IMultipathPowerDelayProfile multipathPowerDelayProfile in multipathPowerDelayProfiles)
            {
                List<IAntenna>? antennas_1 = GeometricalPropagationModel.GetAntennas<IAntenna>(multipathPowerDelayProfile);
                if (antennas_1 != null)
                {
                    foreach (IAntenna antenna_1 in antennas_1)
                    {
                        List<IAntenna>? antennas_2 = GeometricalPropagationModel.GetAntennas<IAntenna>(multipathPowerDelayProfile, antenna_1);
                        if (antennas_2 != null)
                        {
                            foreach (IAntenna antenna_2 in antennas_2)
                            {
                                if (tuples.Find(x => (x.Item1.Guid == antenna_1.Guid && x.Item2.Guid == antenna_2.Guid) || (x.Item2.Guid == antenna_1.Guid && x.Item1.Guid == antenna_2.Guid)) == null)
                                {
                                    tuples.Add(new Tuple<IAntenna, IAntenna, IMultipathPowerDelayProfile>(antenna_1, antenna_2, multipathPowerDelayProfile));
                                }
                            }
                        }
                    }
                }

                tuples.RemoveAll(x => x.Item1.Functions == null || x.Item1.Functions.Count == 0 || x.Item2.Functions == null || x.Item2.Functions.Count == 0);
                tuples.RemoveAll(x => !x.Item1.Functions!.Contains(Enums.Function.Receiver) && !x.Item2.Functions!.Contains(Enums.Function.Receiver));
                tuples.RemoveAll(x => !x.Item1.Functions!.Contains(Enums.Function.Transmitter) && !x.Item2.Functions!.Contains(Enums.Function.Transmitter));
            }

            if (tuples.Count == 0)
            {
                return false;
            }

            scatteringProfiles = [];


            //Scattering objects are processed per group so a single group bounding box can cull all objects of the group at once (broad-phase intersection check).

            List<Tuple<BoundingBox3D, List<IScatteringObject>>> tuples_ScatteringObjects = [];

            //Get ungrouped scattering objects from the GeometricalPropagationModel. This will be used to create one bounding box for ungrouped scattering objects.
            List<IScatteringObject>? scatteringObjects_Ungrouped = GeometricalPropagationModel.GetScatteringObjects<IScatteringObject>(false);
            if(scatteringObjects_Ungrouped is not null && scatteringObjects_Ungrouped.Count > 0)
            {
                BoundingBox3D? boundingBox3D = Geometry.Spatial.Create.BoundingBox3D(scatteringObjects_Ungrouped.ConvertAll(x => x.Mesh3D?.GetBoundingBox()).FindAll(x => x is not null)!);
                if(boundingBox3D is not null)
                {
                    tuples_ScatteringObjects.Add(new Tuple<BoundingBox3D, List<IScatteringObject>>(boundingBox3D, scatteringObjects_Ungrouped));
                }
            }

            //Get grouped scattering objects from the GeometricalPropagationModel. This will be used to get one bounding box for each group of scattering objects.
            List<IScatteringGroup>? scatteringGroups = GeometricalPropagationModel.GetScatteringGroups<IScatteringGroup>();
            if(scatteringGroups is not null && scatteringGroups.Count > 0)
            {
                foreach (IScatteringGroup scatteringGroup in scatteringGroups)
                {
                    List<IScatteringObject>? scatteringObjects_Group = GeometricalPropagationModel.GetScatteringObjects<IScatteringObject>(scatteringGroup);
                    if (scatteringObjects_Group is not null && scatteringObjects_Group.Count > 0)
                    {
                        if (scatteringGroup.BoundingBox3D is BoundingBox3D boundingBox3D)
                        {
                            tuples_ScatteringObjects.Add(new Tuple<BoundingBox3D, List<IScatteringObject>>(boundingBox3D, scatteringObjects_Group));
                        }
                    }
                }
            }

            List<CachedScatteringGroup> cachedScatteringGroups = [];
            foreach (Tuple<BoundingBox3D, List<IScatteringObject>> tuple_ScatteringObjects in tuples_ScatteringObjects)
            {
                List<CachedFaceInfo> cachedFaceInfos = [];
                List<BoundingBox3D> boundingBox3Ds = [];

                foreach (IScatteringObject scatteringObject in tuple_ScatteringObjects.Item2)
                {
                    Mesh3D? mesh3D_ScatteringObject = scatteringObject?.Mesh3D;
                    if (mesh3D_ScatteringObject == null)
                    {
                        continue;
                    }

                    string? reference = scatteringObject?.Reference;
                    reference ??= string.Empty;

                    List<Triangle3D>? triangles_Temp = mesh3D_ScatteringObject.GetTriangles();
                    if (triangles_Temp == null)
                    {
                        continue;
                    }

                    foreach (Triangle3D triangle3D in triangles_Temp)
                    {
                        PolygonalFace3D face = new(triangle3D);

                        BoundingBox3D? boundingBox3D_Face = face.GetBoundingBox();
                        if (boundingBox3D_Face == null)
                        {
                            continue;
                        }

                        cachedFaceInfos.Add(new CachedFaceInfo
                        {
                            Face = face,
                            BBox = boundingBox3D_Face,
                            Reference = reference,
                            Triangle = triangle3D
                        });
                    }

                    if (mesh3D_ScatteringObject.GetBoundingBox() is BoundingBox3D boundingBox3D_ScatteringObject)
                    {
                        boundingBox3Ds.Add(boundingBox3D_ScatteringObject);
                    }
                }

                if (cachedFaceInfos.Count == 0)
                {
                    continue;
                }

                double[] faceSlabs = new double[cachedFaceInfos.Count * 6];
                double[] faceTriangles = new double[cachedFaceInfos.Count * 16];
                for (int k = 0; k < cachedFaceInfos.Count; k++)
                {
                    CachedFaceInfo cachedFaceInfo = cachedFaceInfos[k];

                    int offset_Slab = k * 6;
                    faceSlabs[offset_Slab] = cachedFaceInfo.BBox.MinX;
                    faceSlabs[offset_Slab + 1] = cachedFaceInfo.BBox.MinY;
                    faceSlabs[offset_Slab + 2] = cachedFaceInfo.BBox.MinZ;
                    faceSlabs[offset_Slab + 3] = cachedFaceInfo.BBox.MaxX;
                    faceSlabs[offset_Slab + 4] = cachedFaceInfo.BBox.MaxY;
                    faceSlabs[offset_Slab + 5] = cachedFaceInfo.BBox.MaxZ;

                    int offset_Triangle = k * 16;
                    faceTriangles[offset_Triangle] = double.NaN;

                    Point3D? point3D_0 = cachedFaceInfo.Triangle[0];
                    Point3D? point3D_1 = cachedFaceInfo.Triangle[1];
                    Point3D? point3D_2 = cachedFaceInfo.Triangle[2];
                    if (point3D_0 == null || point3D_1 == null || point3D_2 == null)
                    {
                        continue;
                    }

                    double vector1X = point3D_1.X - point3D_0.X;
                    double vector1Y = point3D_1.Y - point3D_0.Y;
                    double vector1Z = point3D_1.Z - point3D_0.Z;

                    double vector2X = point3D_2.X - point3D_0.X;
                    double vector2Y = point3D_2.Y - point3D_0.Y;
                    double vector2Z = point3D_2.Z - point3D_0.Z;

                    double normalX = (vector1Y * vector2Z) - (vector1Z * vector2Y);
                    double normalY = (vector1Z * vector2X) - (vector1X * vector2Z);
                    double normalZ = (vector1X * vector2Y) - (vector1Y * vector2X);

                    double normalLength = Math.Sqrt((normalX * normalX) + (normalY * normalY) + (normalZ * normalZ));
                    if (normalLength < 1e-12)
                    {
                        continue;
                    }

                    normalX /= normalLength;
                    normalY /= normalLength;
                    normalZ /= normalLength;

                    //Per-edge inward normals oriented towards the opposite vertex; a degenerate edge leaves the NaN marker so the exact test is used
                    Point3D[] point3Ds_Triangle = [point3D_0, point3D_1, point3D_2];
                    bool valid = true;
                    for (int m = 0; m < 3; m++)
                    {
                        Point3D point3D_From = point3Ds_Triangle[m];
                        Point3D point3D_To = point3Ds_Triangle[(m + 1) % 3];
                        Point3D point3D_Opposite = point3Ds_Triangle[(m + 2) % 3];

                        double edgeX = point3D_To.X - point3D_From.X;
                        double edgeY = point3D_To.Y - point3D_From.Y;
                        double edgeZ = point3D_To.Z - point3D_From.Z;

                        double inwardX = (normalY * edgeZ) - (normalZ * edgeY);
                        double inwardY = (normalZ * edgeX) - (normalX * edgeZ);
                        double inwardZ = (normalX * edgeY) - (normalY * edgeX);

                        double inwardLength = Math.Sqrt((inwardX * inwardX) + (inwardY * inwardY) + (inwardZ * inwardZ));
                        if (inwardLength < 1e-12)
                        {
                            valid = false;
                            break;
                        }

                        inwardX /= inwardLength;
                        inwardY /= inwardLength;
                        inwardZ /= inwardLength;

                        if (((inwardX * (point3D_Opposite.X - point3D_From.X)) + (inwardY * (point3D_Opposite.Y - point3D_From.Y)) + (inwardZ * (point3D_Opposite.Z - point3D_From.Z))) < 0)
                        {
                            inwardX = -inwardX;
                            inwardY = -inwardY;
                            inwardZ = -inwardZ;
                        }

                        int offset_Edge = offset_Triangle + 4 + (m * 4);
                        faceTriangles[offset_Edge] = inwardX;
                        faceTriangles[offset_Edge + 1] = inwardY;
                        faceTriangles[offset_Edge + 2] = inwardZ;
                        faceTriangles[offset_Edge + 3] = (inwardX * point3D_From.X) + (inwardY * point3D_From.Y) + (inwardZ * point3D_From.Z);
                    }

                    if (!valid)
                    {
                        continue;
                    }

                    faceTriangles[offset_Triangle] = normalX;
                    faceTriangles[offset_Triangle + 1] = normalY;
                    faceTriangles[offset_Triangle + 2] = normalZ;
                    faceTriangles[offset_Triangle + 3] = (normalX * point3D_0.X) + (normalY * point3D_0.Y) + (normalZ * point3D_0.Z);
                }

                cachedScatteringGroups.Add(new CachedScatteringGroup(tuple_ScatteringObjects.Item1, boundingBox3Ds, [.. cachedFaceInfos], faceSlabs, faceTriangles));
            }

            if (cachedScatteringGroups.Count == 0)
            {
                for (int i = 0; i < tuples.Count; i++)
                {
                    IAntenna antenna_1 = tuples[i].Item1;
                    IAntenna antenna_2 = tuples[i].Item2;

                    IMultipathPowerDelayProfile multipathPowerDelayProfile = tuples[i].Item3;

                    bool visible = true;

                    ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile = multipathPowerDelayProfile is ISimpleMultipathPowerDelayProfile profile ? profile : ((IComplexMultipathPowerDelayProfile)multipathPowerDelayProfile).GetSimpleMultipathPowerDelay(visible);

                    HashSet<double>? delays = simpleMultipathPowerDelayProfile?.Delays;
                    if (delays == null || delays.Count == 0)
                    {
                        continue;
                    }

                    List<Scattering> scatterings = [];
                    foreach (double delay in delays)
                    {
                        scatterings.Add(new Scattering(delay));
                    }

                    ScatteringProfile scatteringProfile = new(visible, antenna_1.Location, antenna_2.Location, scatterings);
                    GeometricalPropagationModel.Assign(scatteringProfile, antenna_1, antenna_2);
                    GeometricalPropagationModel.Assign(scatteringProfile, multipathPowerDelayProfile);
                    scatteringProfiles.Add(scatteringProfile);
                }

                return true;
            }

            //Scalar counterpart of BoundingBox3D.InRange(Point3D, Point3D, true, true, tolerance) working on flat data (no object graph traversal)
            static bool InRangeSlab(
                double minX,
                double minY,
                double minZ,
                double maxX,
                double maxY,
                double maxZ,
                double originX,
                double originY,
                double originZ,
                double directionX,
                double directionY,
                double directionZ,
                double tolerance)
            {
                double tMin = 0.0;
                double tMax = 1.0;

                if (Math.Abs(directionX) < 1e-12)
                {
                    if (originX < minX - tolerance || originX > maxX + tolerance)
                    {
                        return false;
                    }
                }
                else
                {
                    double t0 = (minX - tolerance - originX) / directionX;
                    double t1 = (maxX + tolerance - originX) / directionX;
                    if (t0 > t1)
                    {
                        (t1, t0) = (t0, t1);
                    }
                    if (t0 > tMin) tMin = t0;
                    if (t1 < tMax) tMax = t1;
                    if (tMin > tMax) return false;
                }

                if (Math.Abs(directionY) < 1e-12)
                {
                    if (originY < minY - tolerance || originY > maxY + tolerance)
                    {
                        return false;
                    }
                }
                else
                {
                    double t0 = (minY - tolerance - originY) / directionY;
                    double t1 = (maxY + tolerance - originY) / directionY;
                    if (t0 > t1)
                    {
                        (t1, t0) = (t0, t1);
                    }
                    if (t0 > tMin) tMin = t0;
                    if (t1 < tMax) tMax = t1;
                    if (tMin > tMax) return false;
                }

                if (Math.Abs(directionZ) < 1e-12)
                {
                    if (originZ < minZ - tolerance || originZ > maxZ + tolerance)
                    {
                        return false;
                    }
                }
                else
                {
                    double t0 = (minZ - tolerance - originZ) / directionZ;
                    double t1 = (maxZ + tolerance - originZ) / directionZ;
                    if (t0 > t1)
                    {
                        (t1, t0) = (t0, t1);
                    }
                    if (t0 > tMin) tMin = t0;
                    if (t1 < tMax) tMax = t1;
                    if (tMin > tMax) return false;
                }

                return true;
            }

            //Conservative scalar segment-triangle occlusion test matching Query.Intersect(face, segment, tolerance, false, false) decisions.
            //Returns -1 (definitely no intersection), 1 (definitely intersects away from segment ends) or 0 (near-tolerance case - caller must run the exact test).
            static int SegmentTriangleIntersectionState(
                double[] faceTriangles,
                int offset,
                double startX,
                double startY,
                double startZ,
                double endX,
                double endY,
                double endZ,
                double length,
                double margin)
            {
                double normalX = faceTriangles[offset];
                if (double.IsNaN(normalX))
                {
                    return 0;
                }

                double normalY = faceTriangles[offset + 1];
                double normalZ = faceTriangles[offset + 2];
                double planeOffset = faceTriangles[offset + 3];

                double distance_Start = (normalX * startX) + (normalY * startY) + (normalZ * startZ) - planeOffset;
                double distance_End = (normalX * endX) + (normalY * endY) + (normalZ * endZ) - planeOffset;

                if (distance_Start > margin && distance_End > margin)
                {
                    return -1;
                }

                if (distance_Start < -margin && distance_End < -margin)
                {
                    return -1;
                }

                if (Math.Abs(distance_Start) <= margin || Math.Abs(distance_End) <= margin)
                {
                    return 0;
                }

                double t = distance_Start / (distance_Start - distance_End);
                if (t * length <= margin || (1.0 - t) * length <= margin)
                {
                    return 0;
                }

                double pointX = startX + (t * (endX - startX));
                double pointY = startY + (t * (endY - startY));
                double pointZ = startZ + (t * (endZ - startZ));

                bool uncertain = false;
                for (int m = 0; m < 3; m++)
                {
                    int offset_Edge = offset + 4 + (m * 4);
                    double distance_Edge = (faceTriangles[offset_Edge] * pointX) + (faceTriangles[offset_Edge + 1] * pointY) + (faceTriangles[offset_Edge + 2] * pointZ) - faceTriangles[offset_Edge + 3];
                    if (distance_Edge <= -margin)
                    {
                        return -1;
                    }

                    if (distance_Edge < margin)
                    {
                        uncertain = true;
                    }
                }

                return uncertain ? 0 : 1;
            }

            static List<Segment3D> GetTriangleTriangleIntersectionSegments(Triangle3D triangle3D_First, PolygonalFace3D polygonalFace3D_First, PolygonalFace3D polygonalFace3D_Second, double tolerance)
            {
                BoundingBox3D? boundingBox3D_First = triangle3D_First.GetBoundingBox();
                BoundingBox3D? boundingBox3D_Second = polygonalFace3D_Second.GetBoundingBox();
                if (boundingBox3D_First == null || boundingBox3D_Second == null || !boundingBox3D_First.InRange(boundingBox3D_Second, tolerance))
                {
                    return [];
                }

                if (polygonalFace3D_First.Plane != null && polygonalFace3D_Second.Plane != null && polygonalFace3D_First.Plane.Coplanar(polygonalFace3D_Second.Plane, tolerance))
                {
                    PlanarIntersectionResult? planarIntersectionResult = polygonalFace3D_First.PlanarIntersectionResult(polygonalFace3D_Second, tolerance);
                    if (planarIntersectionResult != null && planarIntersectionResult.Any())
                    {
                        List<Segment3D> segment3Ds_Result = [];
                        List<Segment3D>? segment3Ds = planarIntersectionResult.GetGeometry3Ds<Segment3D>();
                        if (segment3Ds != null)
                        {
                            segment3Ds_Result.AddRange(segment3Ds);
                        }
                        List<IPolygonalFace3D>? polygonalFace3D_Intersects = planarIntersectionResult.GetGeometry3Ds<IPolygonalFace3D>();
                        if (polygonalFace3D_Intersects != null)
                        {
                            foreach (IPolygonalFace3D polygonalFace3D_Intersect in polygonalFace3D_Intersects)
                            {
                                List<IPolygonal3D>? polygonal3Ds_Edges = polygonalFace3D_Intersect.Edges;
                                if (polygonal3Ds_Edges != null)
                                {
                                    foreach (IPolygonal3D polygonal3D_Edge in polygonal3Ds_Edges)
                                    {
                                        List<Segment3D>? segment3Ds_Face = polygonal3D_Edge.GetSegments();
                                        if (segment3Ds_Face != null)
                                        {
                                            segment3Ds_Result.AddRange(segment3Ds_Face);
                                        }
                                    }
                                }
                            }
                        }
                        return segment3Ds_Result;
                    }
                    return [];
                }

                Point3D? point3D_1 = triangle3D_First[0];
                Point3D? point3D_2 = triangle3D_First[1];
                Point3D? point3D_3 = triangle3D_First[2];
                if (point3D_1 == null || point3D_2 == null || point3D_3 == null)
                {
                    return [];
                }

                List<Point3D> point3Ds_Intersection = [];
                Segment3D[] segment3Ds_EdgesFirst = [
                    new Segment3D(point3D_1, point3D_2),
                    new Segment3D(point3D_2, point3D_3),
                    new Segment3D(point3D_3, point3D_1)
                ];

                foreach (Segment3D segment3D_Edge in segment3Ds_EdgesFirst)
                {
                    PlanarIntersectionResult? planarIntersectionResult_Edge = polygonalFace3D_Second.PlanarIntersectionResult(segment3D_Edge, tolerance);
                    if (planarIntersectionResult_Edge != null && planarIntersectionResult_Edge.Any())
                    {
                        List<Point3D>? point3Ds_Temp = planarIntersectionResult_Edge.GetGeometry3Ds<Point3D>();
                        if (point3Ds_Temp != null)
                        {
                            point3Ds_Intersection.AddRange(point3Ds_Temp);
                        }
                        List<Segment3D>? segment3Ds_Temp = planarIntersectionResult_Edge.GetGeometry3Ds<Segment3D>();
                        if (segment3Ds_Temp != null)
                        {
                            foreach (Segment3D segment3D_Temp in segment3Ds_Temp)
                            {
                                if (segment3D_Temp.Start is Point3D point3D_Start)
                                {
                                    point3Ds_Intersection.Add(point3D_Start);
                                }

                                if (segment3D_Temp.End is Point3D point3D_End)
                                {
                                    point3Ds_Intersection.Add(point3D_End);
                                }
                            }
                        }
                    }
                }

                List<IPolygonal3D>? polygonal3Ds_EdgesSecond = polygonalFace3D_Second.Edges;
                if (polygonal3Ds_EdgesSecond != null)
                {
                    foreach (IPolygonal3D polygonal3D_Edge in polygonal3Ds_EdgesSecond)
                    {
                        List<Segment3D>? segment3Ds_Second = polygonal3D_Edge.GetSegments();
                        if (segment3Ds_Second != null)
                        {
                            foreach (Segment3D segment3D_Second in segment3Ds_Second)
                            {
                                PlanarIntersectionResult? planarIntersectionResult_Second = polygonalFace3D_First.PlanarIntersectionResult(segment3D_Second, tolerance);
                                if (planarIntersectionResult_Second != null && planarIntersectionResult_Second.Any())
                                {
                                    List<Point3D>? point3Ds_Temp = planarIntersectionResult_Second.GetGeometry3Ds<Point3D>();
                                    if (point3Ds_Temp != null)
                                    {
                                        point3Ds_Intersection.AddRange(point3Ds_Temp);
                                    }
                                    List<Segment3D>? segment3Ds_Temp = planarIntersectionResult_Second.GetGeometry3Ds<Segment3D>();
                                    if (segment3Ds_Temp != null)
                                    {
                                        foreach (Segment3D segment3D_Temp in segment3Ds_Temp)
                                        {
                                            if (segment3D_Temp.Start is Point3D point3D_Start)
                                            {
                                                point3Ds_Intersection.Add(point3D_Start);
                                            }

                                            if (segment3D_Temp.End is Point3D point3D_End)
                                            {
                                                point3Ds_Intersection.Add(point3D_End);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                List<Point3D> point3Ds_Unique = [];
                foreach (Point3D point3D in point3Ds_Intersection)
                {
                    bool exists = false;
                    foreach (Point3D point3D_Unique in point3Ds_Unique)
                    {
                        if (point3D.Distance(point3D_Unique) <= tolerance)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        point3Ds_Unique.Add(point3D);
                    }
                }

                if (point3Ds_Unique.Count >= 2)
                {
                    Point3D point3D_A = point3Ds_Unique[0];
                    Point3D point3D_B = point3Ds_Unique[1];
                    double maxDistanceSquared = point3D_A.Distance(point3D_B);
                    maxDistanceSquared = maxDistanceSquared * maxDistanceSquared;

                    for (int i = 0; i < point3Ds_Unique.Count; i++)
                    {
                        for (int j = i + 1; j < point3Ds_Unique.Count; j++)
                        {
                            double distance = point3Ds_Unique[i].Distance(point3Ds_Unique[j]);
                            double distanceSquared = distance * distance;
                            if (distanceSquared > maxDistanceSquared)
                            {
                                maxDistanceSquared = distanceSquared;
                                point3D_A = point3Ds_Unique[i];
                                point3D_B = point3Ds_Unique[j];
                            }
                        }
                    }

                    if (System.Math.Sqrt(maxDistanceSquared) > tolerance)
                    {
                        return [new Segment3D(point3D_A, point3D_B)];
                    }
                }

                return [];
            }

            static List<Point3D> SegmentPoints(Segment3D segment, double distance, bool includeShorter, double toleranceVal)
            {
                double length = segment.Length;
                if (length < toleranceVal)
                {
                    if (includeShorter)
                    {
                        return [new Point3D(segment.Start), new Point3D(segment.End)];
                    }

                    return [];
                }

                int numPoints = System.Convert.ToInt32(Math.Truncate(length / distance));

                List<Point3D> resultPoints = [];
                Vector3D? directionNullable = segment.Direction;
                Point3D? startPoint = segment.Start;
                Point3D? endPoint = segment.End;
                if (directionNullable == null || startPoint == null || endPoint == null)
                {
                    return [];
                }

                Vector3D direction = directionNullable;
                Vector3D vector = (direction * distance)!;
                Point3D point = segment.Mid() ?? new Point3D((startPoint.X + endPoint.X) * 0.5, (startPoint.Y + endPoint.Y) * 0.5, (startPoint.Z + endPoint.Z) * 0.5);

                if (numPoints % 2 != 0)
                {
                    point = point.GetMoved(vector.GetInversed() * 0.5) ?? point;
                }

                resultPoints.Add(point);

                for (int j = 1; j <= numPoints; j++)
                {
                    if (j % 2 == 0)
                    {
                        point = resultPoints[0].GetMoved(vector) ?? resultPoints[0];
                        resultPoints.Insert(0, point);
                    }
                    else
                    {
                        point = resultPoints[resultPoints.Count - 1].GetMoved(vector) ?? resultPoints[resultPoints.Count - 1];
                        resultPoints.Add(point);
                    }

                    vector = vector.GetInversed();
                }

                if (includeShorter)
                {
                    if (point.Distance(resultPoints[0]) > toleranceVal)
                    {
                        resultPoints.Insert(0, new Point3D(startPoint));
                    }

                    if (point.Distance(resultPoints[resultPoints.Count - 1]) > toleranceVal)
                    {
                        resultPoints.Add(new Point3D(endPoint));
                    }
                }

                return resultPoints;
            }

            static List<List<Segment3D>> GroupSegmentsIntoComponents(List<Segment3D> segments, double toleranceVal)
            {
                List<List<Segment3D>> components = [];
                if (segments == null || segments.Count == 0)
                {
                    return components;
                }

                bool[] visited = new bool[segments.Count];
                for (int index_Outer = 0; index_Outer < segments.Count; index_Outer++)
                {
                    if (visited[index_Outer])
                    {
                        continue;
                    }

                    List<Segment3D> component = [];
                    Queue<int> queue = new();
                    queue.Enqueue(index_Outer);
                    visited[index_Outer] = true;

                    while (queue.Count > 0)
                    {
                        int current = queue.Dequeue();
                        Segment3D currentSegment = segments[current];
                        component.Add(currentSegment);

                        Point3D? currentStart = currentSegment.Start;
                        Point3D? currentEnd = currentSegment.End;

                        for (int index_Inner = 0; index_Inner < segments.Count; index_Inner++)
                        {
                            if (visited[index_Inner])
                            {
                                continue;
                            }

                            Segment3D checkSegment = segments[index_Inner];
                            Point3D? checkStart = checkSegment.Start;
                            Point3D? checkEnd = checkSegment.End;

                            bool connected = false;
                            if (currentStart != null && checkStart != null && currentStart.Distance(checkStart) <= toleranceVal)
                            {
                                connected = true;
                            }
                            else if (currentStart != null && checkEnd != null && currentStart.Distance(checkEnd) <= toleranceVal)
                            {
                                connected = true;
                            }
                            else if (currentEnd != null && checkStart != null && currentEnd.Distance(checkStart) <= toleranceVal)
                            {
                                connected = true;
                            }
                            else if (currentEnd != null && checkEnd != null && currentEnd.Distance(checkEnd) <= toleranceVal)
                            {
                                connected = true;
                            }

                            if (connected)
                            {
                                visited[index_Inner] = true;
                                queue.Enqueue(index_Inner);
                            }
                        }
                    }

                    components.Add(component);
                }

                return components;
            }

            List<bool> intersects = [];
            foreach (Tuple<IAntenna, IAntenna, IMultipathPowerDelayProfile> tuple in tuples)
            {
                if (tuple.Item1?.Location is not Point3D point_1 || tuple.Item2?.Location is not Point3D point_2)
                {
                    intersects.Add(true);
                    continue;
                }

                Segment3D segment = new(point_1, point_2);
                bool hasIntersection = false;
                foreach (CachedScatteringGroup cachedScatteringGroup in cachedScatteringGroups)
                {
                    // Group bounding box broad-phase check culls all faces of the group at once
                    if (!cachedScatteringGroup.BoundingBox3D.InRange(segment, tolerance))
                    {
                        continue;
                    }

                    foreach (CachedFaceInfo cachedFace in cachedScatteringGroup.CachedFaceInfos)
                    {
                        if (!cachedFace.BBox.InRange(segment, tolerance))
                        {
                            continue;
                        }

                        if (cachedFace.Face.Intersect(segment, tolerance, true, true))
                        {
                            hasIntersection = true;
                            break;
                        }
                    }

                    if (hasIntersection)
                    {
                        break;
                    }
                }
                intersects.Add(hasIntersection);
            }

            for (int i = 0; i < tuples.Count; i++)
            {
                IAntenna? antenna_1 = tuples[i].Item1;
                IAntenna? antenna_2 = tuples[i].Item2;
                if (antenna_1 == null || antenna_2 == null)
                {
                    continue;
                }

                bool visible = !intersects[i];

                IMultipathPowerDelayProfile multipathPowerDelayProfile = tuples[i].Item3;

                ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile = multipathPowerDelayProfile is ISimpleMultipathPowerDelayProfile profile ? profile : ((IComplexMultipathPowerDelayProfile)multipathPowerDelayProfile).GetSimpleMultipathPowerDelay(visible);

                HashSet<double>? delays = simpleMultipathPowerDelayProfile?.Delays;
                if (delays == null || delays.Count == 0)
                {
                    continue;
                }

                SortedDictionary<double, Tuple<Ellipsoid, Mesh3D, List<Triangle3D>?>?> sortedDictionary = [];
                foreach (double delay in delays)
                {
                    if (double.IsNaN(delay))
                    {
                        continue;
                    }

                    sortedDictionary[delay] = null;
                }

                double[] delays_Sorted = [.. sortedDictionary.Keys];

                Parallel.ForEach(delays_Sorted, delay =>
                {
                    Ellipsoid? ellipsoid = Create.Ellipsoid(antenna_1, antenna_2, delay, tolerance);
                    if (ellipsoid == null)
                    {
                        return;
                    }

                    Mesh3D? mesh3D = ellipsoid.Mesh3D(angleFactor);
                    if (mesh3D == null)
                    {
                        return;
                    }

                    List<Triangle3D>? triangle3Ds_Ellipsoid = mesh3D.GetTriangles();
                    if (triangle3Ds_Ellipsoid == null || triangle3Ds_Ellipsoid.Count == 0)
                    {
                        return;
                    }

                    for (int j = triangle3Ds_Ellipsoid.Count - 1; j >= 0; j--)
                    {
                        Triangle3D triangle3D = triangle3Ds_Ellipsoid[j];

                        BoundingBox3D? boundingBox3D_Triangle3D = triangle3D.GetBoundingBox();

                        bool inRange = false;
                        foreach (CachedScatteringGroup cachedScatteringGroup in cachedScatteringGroups)
                        {
                            // Group bounding box broad-phase check culls all scattering objects of the group at once
                            if (!cachedScatteringGroup.BoundingBox3D.InRange(boundingBox3D_Triangle3D, tolerance))
                            {
                                continue;
                            }

                            if (cachedScatteringGroup.BoundingBox3Ds.FindIndex(x => x.InRange(boundingBox3D_Triangle3D, tolerance)) >= 0)
                            {
                                inRange = true;
                                break;
                            }
                        }

                        if (inRange)
                        {
                            continue;
                        }

                        triangle3Ds_Ellipsoid.RemoveAt(j);
                    }

                    lock (sortedDictionary)
                    {
                        sortedDictionary[delay] = new Tuple<Ellipsoid, Mesh3D, List<Triangle3D>?>(ellipsoid, mesh3D, triangle3Ds_Ellipsoid);
                    }
                });

                Point3D? location_1 = antenna_1?.Location;
                if (location_1 is null)
                {
                    return false;
                }

                Point3D? location_2 = antenna_2?.Location;
                if (location_2 is null)
                {
                    return false;
                }

                // Process delays in parallel to fully utilize CPU cores
                ConcurrentBag<Scattering> concurrentScatterings = [];

                Parallel.ForEach(sortedDictionary, keyValuePair =>
                {
                    double delay = keyValuePair.Key;
                    Tuple<Ellipsoid, Mesh3D, List<Triangle3D>?>? dataTuple = keyValuePair.Value;

                    List<Triangle3D>? triangle3Ds_Ellipsoid = dataTuple?.Item3;
                    if (triangle3Ds_Ellipsoid == null || triangle3Ds_Ellipsoid.Count == 0)
                    {
                        concurrentScatterings.Add(new Scattering(delay));
                        return;
                    }

                    List<ScatteringPointGroup> scatteringPointGroups = [];
                    List<IntersectionSegment> intersectionSegments = [];

                    foreach (Triangle3D triangleEllipsoid in triangle3Ds_Ellipsoid)
                    {
                        BoundingBox3D? boundingBox3D_Ellipsoid = triangleEllipsoid.GetBoundingBox();
                        if (boundingBox3D_Ellipsoid == null)
                        {
                            continue;
                        }

                        PolygonalFace3D polygonalFace3D_Ellipsoid = new(triangleEllipsoid);

                        foreach (CachedScatteringGroup cachedScatteringGroup in cachedScatteringGroups)
                        {
                            // Group bounding box broad-phase check culls all faces of the group at once
                            if (!boundingBox3D_Ellipsoid.InRange(cachedScatteringGroup.BoundingBox3D, tolerance))
                            {
                                continue;
                            }

                            foreach (CachedFaceInfo cachedFace in cachedScatteringGroup.CachedFaceInfos)
                            {
                                // Bounding box overlapping check prevents expensive face-face intersection checks
                                if (!boundingBox3D_Ellipsoid.InRange(cachedFace.BBox, tolerance))
                                {
                                    continue;
                                }

                                List<Segment3D> segment3Ds_Temp = GetTriangleTriangleIntersectionSegments(triangleEllipsoid, polygonalFace3D_Ellipsoid, cachedFace.Face, tolerance);
                                if (segment3Ds_Temp.Count > 0)
                                {
                                    string reference = cachedFace.Reference ?? string.Empty;
                                    foreach (Segment3D segment3D in segment3Ds_Temp)
                                    {
                                        intersectionSegments.Add(new IntersectionSegment
                                        {
                                            Segment = segment3D,
                                            Reference = reference
                                        });
                                    }
                                }
                            }
                        }
                    }

                    if (intersectionSegments.Count != 0)
                    {
                        Dictionary<string, List<Segment3D>> segmentsByReference = [];
                        foreach (IntersectionSegment intersectionSegment in intersectionSegments)
                        {
                            if (!segmentsByReference.TryGetValue(intersectionSegment.Reference, out List<Segment3D>? segmentList) || segmentList == null)
                            {
                                segmentList = [];
                                segmentsByReference[intersectionSegment.Reference] = segmentList;
                            }
                            segmentList.Add(intersectionSegment.Segment);
                        }

                        List<SegmentComponent> segmentComponents = [];
                        foreach (KeyValuePair<string, List<Segment3D>> keyValuePair_Temp in segmentsByReference)
                        {
                            List<List<Segment3D>> components = GroupSegmentsIntoComponents(keyValuePair_Temp.Value, tolerance);
                            foreach (List<Segment3D> component in components)
                            {
                                segmentComponents.Add(new SegmentComponent(keyValuePair_Temp.Key, component));
                            }
                        }

                        List<CandidatePoint> candidates_First = [];

                        foreach (SegmentComponent segmentComponent in segmentComponents)
                        {
                            foreach (Segment3D segment3D in segmentComponent.Segments)
                            {
                                List<Point3D> point3Ds_Sub = SegmentPoints(segment3D, pointDensityFactor, true, tolerance);
                                if (point3Ds_Sub == null)
                                {
                                    continue;
                                }

                                foreach (Point3D point3D in point3Ds_Sub)
                                {
                                    Segment3D segment3D_Temp = new(location_1, point3D);
                                    candidates_First.Add(new CandidatePoint
                                    {
                                        SegmentToLoc = segment3D_Temp,
                                        Point = point3D,
                                        Component = segmentComponent
                                    });
                                }
                            }
                        }

                        if (candidates_First.Count != 0)
                        {
                            double originX = location_1.X;
                            double originY = location_1.Y;
                            double originZ = location_1.Z;

                            List<CandidatePoint> candidates_Second = [];
                            foreach (CandidatePoint candidate_First in candidates_First)
                            {
                                double endX = candidate_First.Point.X;
                                double endY = candidate_First.Point.Y;
                                double endZ = candidate_First.Point.Z;

                                double directionX = endX - originX;
                                double directionY = endY - originY;
                                double directionZ = endZ - originZ;
                                double length = Math.Sqrt((directionX * directionX) + (directionY * directionY) + (directionZ * directionZ));

                                bool hasIntersection = false;
                                foreach (CachedScatteringGroup cachedScatteringGroup in cachedScatteringGroups)
                                {
                                    // Group bounding box broad-phase check culls all faces of the group at once
                                    if (!InRangeSlab(cachedScatteringGroup.MinX, cachedScatteringGroup.MinY, cachedScatteringGroup.MinZ, cachedScatteringGroup.MaxX, cachedScatteringGroup.MaxY, cachedScatteringGroup.MaxZ, originX, originY, originZ, directionX, directionY, directionZ, tolerance))
                                    {
                                        continue;
                                    }

                                    double[] faceSlabs = cachedScatteringGroup.FaceSlabs;
                                    double[] faceTriangles = cachedScatteringGroup.FaceTriangles;
                                    CachedFaceInfo[] cachedFaceInfos_Group = cachedScatteringGroup.CachedFaceInfos;

                                    for (int k = 0; k < cachedFaceInfos_Group.Length; k++)
                                    {
                                        // Bounding box range check prevents expensive segment-face intersection checks
                                        int offset_Slab = k * 6;
                                        if (!InRangeSlab(faceSlabs[offset_Slab], faceSlabs[offset_Slab + 1], faceSlabs[offset_Slab + 2], faceSlabs[offset_Slab + 3], faceSlabs[offset_Slab + 4], faceSlabs[offset_Slab + 5], originX, originY, originZ, directionX, directionY, directionZ, tolerance))
                                        {
                                            continue;
                                        }

                                        int state = SegmentTriangleIntersectionState(faceTriangles, k * 16, originX, originY, originZ, endX, endY, endZ, length, margin);
                                        if (state == -1)
                                        {
                                            continue;
                                        }

                                        if (state == 1 || cachedFaceInfos_Group[k].Face.Intersect(candidate_First.SegmentToLoc, tolerance, false, false))
                                        {
                                            hasIntersection = true;
                                            break;
                                        }
                                    }

                                    if (hasIntersection)
                                    {
                                        break;
                                    }
                                }

                                if (!hasIntersection)
                                {
                                    Segment3D segment3D_Temp = new(location_2, candidate_First.Point);
                                    candidates_Second.Add(new CandidatePoint
                                    {
                                        SegmentToLoc = segment3D_Temp,
                                        Point = candidate_First.Point,
                                        Component = candidate_First.Component
                                    });
                                }
                            }

                            if (candidates_Second.Count != 0)
                            {
                                double originX_2 = location_2.X;
                                double originY_2 = location_2.Y;
                                double originZ_2 = location_2.Z;

                                List<CandidatePoint> candidates_Visible = [];
                                foreach (CandidatePoint candidate_Second in candidates_Second)
                                {
                                    double endX = candidate_Second.Point.X;
                                    double endY = candidate_Second.Point.Y;
                                    double endZ = candidate_Second.Point.Z;

                                    double directionX = endX - originX_2;
                                    double directionY = endY - originY_2;
                                    double directionZ = endZ - originZ_2;
                                    double length = Math.Sqrt((directionX * directionX) + (directionY * directionY) + (directionZ * directionZ));

                                    bool hasIntersection = false;
                                    foreach (CachedScatteringGroup cachedScatteringGroup in cachedScatteringGroups)
                                    {
                                        // Group bounding box broad-phase check culls all faces of the group at once
                                        if (!InRangeSlab(cachedScatteringGroup.MinX, cachedScatteringGroup.MinY, cachedScatteringGroup.MinZ, cachedScatteringGroup.MaxX, cachedScatteringGroup.MaxY, cachedScatteringGroup.MaxZ, originX_2, originY_2, originZ_2, directionX, directionY, directionZ, tolerance))
                                        {
                                            continue;
                                        }

                                        double[] faceSlabs = cachedScatteringGroup.FaceSlabs;
                                        double[] faceTriangles = cachedScatteringGroup.FaceTriangles;
                                        CachedFaceInfo[] cachedFaceInfos_Group = cachedScatteringGroup.CachedFaceInfos;

                                        for (int k = 0; k < cachedFaceInfos_Group.Length; k++)
                                        {
                                            // Bounding box range check prevents expensive segment-face intersection checks
                                            int offset_Slab = k * 6;
                                            if (!InRangeSlab(faceSlabs[offset_Slab], faceSlabs[offset_Slab + 1], faceSlabs[offset_Slab + 2], faceSlabs[offset_Slab + 3], faceSlabs[offset_Slab + 4], faceSlabs[offset_Slab + 5], originX_2, originY_2, originZ_2, directionX, directionY, directionZ, tolerance))
                                            {
                                                continue;
                                            }

                                            int state = SegmentTriangleIntersectionState(faceTriangles, k * 16, originX_2, originY_2, originZ_2, endX, endY, endZ, length, margin);
                                            if (state == -1)
                                            {
                                                continue;
                                            }

                                            if (state == 1 || cachedFaceInfos_Group[k].Face.Intersect(candidate_Second.SegmentToLoc, tolerance, false, false))
                                            {
                                                hasIntersection = true;
                                                break;
                                            }
                                        }

                                        if (hasIntersection)
                                        {
                                            break;
                                        }
                                    }

                                    if (!hasIntersection)
                                    {
                                        candidates_Visible.Add(candidate_Second);
                                    }
                                }

                                if (candidates_Visible.Count != 0)
                                {
                                    Dictionary<SegmentComponent, List<Point3D>> pointsByComponent = [];
                                    foreach (CandidatePoint candidate_Visible in candidates_Visible)
                                    {
                                        if (!pointsByComponent.TryGetValue(candidate_Visible.Component, out List<Point3D>? pointsList) || pointsList == null)
                                        {
                                            pointsList = [];
                                            pointsByComponent[candidate_Visible.Component] = pointsList;
                                        }
                                        pointsList.Add(candidate_Visible.Point);
                                    }

                                    foreach (KeyValuePair<SegmentComponent, List<Point3D>> keyValuePair_Temp in pointsByComponent)
                                    {
                                        scatteringPointGroups.Add(new ScatteringPointGroup(keyValuePair_Temp.Key.Reference, keyValuePair_Temp.Value));
                                    }
                                }
                            }
                        }
                    }

                    concurrentScatterings.Add(new Scattering(delay, scatteringPointGroups));
                });

                List<Scattering> scatterings = [.. concurrentScatterings];
                scatterings.Sort((x, y) => x.Delay.CompareTo(y.Delay));

                ScatteringProfile scatteringProfile = new(visible, antenna_1?.Location, antenna_2?.Location, scatterings);
                GeometricalPropagationModel.Assign(scatteringProfile, antenna_1, antenna_2);
                GeometricalPropagationModel.Assign(scatteringProfile, multipathPowerDelayProfile);
                scatteringProfiles.Add(scatteringProfile);
            }

            return true;
        }
    }
}