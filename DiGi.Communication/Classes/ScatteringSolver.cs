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

            CachedFaceInfo[] cachedFaces = new CachedFaceInfo[faces.Count];
            for (int k = 0; k < faces.Count; k++)
            {
                cachedFaces[k] = new CachedFaceInfo
                {
                    Face = faces[k],
                    BBox = faces[k].GetBoundingBox()!,
                    Reference = references[k]
                };
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

                    PlanarIntersectionResult? result = cachedFace.Face.PlanarIntersectionResult(segment, tolerance);
                    if (result != null && result.Any())
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
                    List<Segment3D> line3s = [];

                    foreach (Triangle3D triangleEllipsoid in triangle3Ds_Ellipsoid)
                    {
                        BoundingBox3D? bboxEllipsoid = triangleEllipsoid.GetBoundingBox();
                        if (bboxEllipsoid == null)
                        {
                            continue;
                        }

                        PolygonalFace3D faceEllipsoid = new(triangleEllipsoid);

                        foreach (CachedFaceInfo cachedFace in cachedFaces)
                        {
                            // Bounding box overlapping check prevents expensive face-face intersection checks
                            if (!bboxEllipsoid.InRange(cachedFace.BBox, tolerance))
                            {
                                continue;
                            }

                            PlanarIntersectionResult? planarIntersectionResult = faceEllipsoid.PlanarIntersectionResult(cachedFace.Face, tolerance);
                            if (planarIntersectionResult != null && planarIntersectionResult.Any())
                            {
                                List<Segment3D>? segments = planarIntersectionResult.GetGeometry3Ds<Segment3D>();
                                if (segments != null)
                                {
                                    line3s.AddRange(segments);
                                }

                                List<IPolygonalFace3D>? intersectFaces = planarIntersectionResult.GetGeometry3Ds<IPolygonalFace3D>();
                                if (intersectFaces != null)
                                {
                                    foreach (IPolygonalFace3D intersectFace in intersectFaces)
                                    {
                                        List<IPolygonal3D>? edges = intersectFace.Edges;
                                        if (edges != null)
                                        {
                                            foreach (IPolygonal3D edge in edges)
                                            {
                                                List<Segment3D>? faceSegments = edge.GetSegments();
                                                if (faceSegments != null)
                                                {
                                                    line3s.AddRange(faceSegments);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (line3s.Count != 0)
                    {
                        List<Tuple<Segment3D, Point3D>> tuples_1 = [];

                        foreach (Segment3D segment in line3s)
                        {
                            List<Point3D> points_Sub = SegmentPoints(segment, pointDensityFactor, true, tolerance);
                            if (points_Sub == null)
                            {
                                continue;
                            }

                            foreach (Point3D point in points_Sub)
                            {
                                Segment3D segment_Temp = new(location_1, point);
                                tuples_1.Add(new Tuple<Segment3D, Point3D>(segment_Temp, point));
                            }
                        }

                        if (tuples_1.Count != 0)
                        {
                            List<Tuple<Segment3D, Point3D>> tuples_2 = [];
                            foreach (Tuple<Segment3D, Point3D> tuple_1 in tuples_1)
                            {
                                bool hasIntersection = false;
                                foreach (CachedFaceInfo cachedFace in cachedFaces)
                                {
                                    // Bounding box range check prevents expensive segment-face intersection checks
                                    if (!cachedFace.BBox.InRange(tuple_1.Item1, tolerance))
                                    {
                                        continue;
                                    }

                                    PlanarIntersectionResult? result = cachedFace.Face.PlanarIntersectionResult(tuple_1.Item1, tolerance);
                                    if (result != null && result.Any())
                                    {
                                        hasIntersection = true;
                                        break;
                                    }
                                }

                                if (!hasIntersection)
                                {
                                    Segment3D segment_Temp = new(location_2, tuple_1.Item2);
                                    tuples_2.Add(new Tuple<Segment3D, Point3D>(segment_Temp, tuple_1.Item2));
                                }
                            }

                            if (tuples_2.Count != 0)
                            {
                                List<Point3D> visiblePoints = [];
                                foreach (Tuple<Segment3D, Point3D> tuple_2 in tuples_2)
                                {
                                    bool hasIntersection = false;
                                    foreach (CachedFaceInfo cachedFace in cachedFaces)
                                    {
                                        // Bounding box range check prevents expensive segment-face intersection checks
                                        if (!cachedFace.BBox.InRange(tuple_2.Item1, tolerance))
                                        {
                                            continue;
                                        }

                                        PlanarIntersectionResult? result = cachedFace.Face.PlanarIntersectionResult(tuple_2.Item1, tolerance);
                                        if (result != null && result.Any())
                                        {
                                            hasIntersection = true;
                                            break;
                                        }
                                    }

                                    if (!hasIntersection)
                                    {
                                        visiblePoints.Add(tuple_2.Item2);
                                    }
                                }

                                if (visiblePoints.Count != 0)
                                {
                                    Dictionary<string, List<Point3D>> dictionary = [];
                                    foreach (Point3D point in visiblePoints)
                                    {
                                        int faceIndex = -1;
                                        for (int k = 0; k < cachedFaces.Length; k++)
                                        {
                                            // Check bounding box before doing expensive Inside test
                                            if (cachedFaces[k].BBox.InRange(point, tolerance) && cachedFaces[k].Face.Inside(point, tolerance))
                                            {
                                                faceIndex = k;
                                                break;
                                            }
                                        }

                                        string reference = faceIndex == -1 ? string.Empty : cachedFaces[faceIndex].Reference;
                                        reference ??= string.Empty;

                                        if (!dictionary.TryGetValue(reference, out List<Point3D>? points_Temp) || points_Temp == null)
                                        {
                                            points_Temp = [];
                                            dictionary[reference] = points_Temp;
                                        }

                                        points_Temp.Add(point);
                                    }

                                    foreach (KeyValuePair<string, List<Point3D>> keyValuePair_Temp in dictionary)
                                    {
                                        scatteringPointGroups.Add(new ScatteringPointGroup(keyValuePair_Temp.Key, keyValuePair_Temp.Value));
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
