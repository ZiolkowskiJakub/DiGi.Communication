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

            List<IScatteringObject>? scatteringObjects = GeometricalPropagationModel.GetScatteringObjects<IScatteringObject>();

            List<PolygonalFace3D> faces = [];
            List<Triangle3D> triangles = [];
            List<string> references = [];
            List<BoundingBox3D> boundingBox3Ds = [];

            if (scatteringObjects != null)
            {
                foreach (IScatteringObject scatteringObject in scatteringObjects)
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
                        faces.Add(face);
                        triangles.Add(triangle3D);
                        references.Add(reference);
                    }

                    if (mesh3D_ScatteringObject.GetBoundingBox() is BoundingBox3D boundingBox3D)
                    {
                        boundingBox3Ds.Add(boundingBox3D);
                    }
                }
            }

            if (faces.Count == 0)
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

            List<CachedFaceInfo> cachedFaceInfos = [];
            for (int k = 0; k < faces.Count; k++)
            {
                BoundingBox3D? boundingBox3D = faces[k].GetBoundingBox();
                if (boundingBox3D != null)
                {
                    cachedFaceInfos.Add(new CachedFaceInfo
                    {
                        Face = faces[k],
                        BBox = boundingBox3D,
                        Reference = references[k],
                        Triangle = triangles[k]
                    });
                }
            }

            CachedFaceInfo[] cachedFaces = [.. cachedFaceInfos];

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
                                if(segment3D_Temp.Start is Point3D point3D_Start)
                                {
                                    point3Ds_Intersection.Add(point3D_Start);
                                }

                                if(segment3D_Temp.End is Point3D point3D_End)
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
                foreach (CachedFaceInfo cachedFace in cachedFaces)
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

                Parallel.ForEach(sortedDictionary.Keys, delay =>
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

                        int index = boundingBox3Ds.FindIndex(x => x.InRange(boundingBox3D_Triangle3D, tolerance));
                        if (index >= 0)
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

                        foreach (CachedFaceInfo cachedFace in cachedFaces)
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
                            List<CandidatePoint> candidates_Second = [];
                            foreach (CandidatePoint candidate_First in candidates_First)
                            {
                                bool hasIntersection = false;
                                foreach (CachedFaceInfo cachedFace in cachedFaces)
                                {
                                    // Bounding box range check prevents expensive segment-face intersection checks
                                    if (!cachedFace.BBox.InRange(candidate_First.SegmentToLoc, tolerance))
                                    {
                                        continue;
                                    }

                                    if (cachedFace.Face.Intersect(candidate_First.SegmentToLoc, tolerance, false, false))
                                    {
                                        hasIntersection = true;
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
                                List<CandidatePoint> candidates_Visible = [];
                                foreach (CandidatePoint candidate_Second in candidates_Second)
                                {
                                    bool hasIntersection = false;
                                    foreach (CachedFaceInfo cachedFace in cachedFaces)
                                    {
                                        // Bounding box range check prevents expensive segment-face intersection checks
                                        if (!cachedFace.BBox.InRange(candidate_Second.SegmentToLoc, tolerance))
                                        {
                                            continue;
                                        }

                                        if (cachedFace.Face.Intersect(candidate_Second.SegmentToLoc, tolerance, false, false))
                                        {
                                            hasIntersection = true;
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
