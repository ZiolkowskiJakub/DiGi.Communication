using ComputeSharp;
using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.ComputeSharp.Geometry.Spatial;
using DiGi.ComputeSharp.Spatial.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using DiGi.ComputeSharp.Spatial.Enums;
using DiGi.ComputeSharp.Spatial.Interfaces;
using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.ComputeSharp.Classes
{
    /// <summary>
    /// Provides functionality to solve scattering calculations within a communication system,
    /// integrating geometrical propagation models and various scattering profiles.
    /// </summary>
    public class ScatteringSolver : ICommunicationObject, ISolver
    {
        private List<IScatteringProfile>? scatteringProfiles;

        private class CandidatePoint
        {
            public Line3 LineToLoc { get; set; }
            public Coordinate3 Point { get; set; }
            public Segment3D ParentSegment { get; set; }

            public CandidatePoint(Line3 lineToLoc, Coordinate3 point, Segment3D parentSegment)
            {
                LineToLoc = lineToLoc;
                Point = point;
                ParentSegment = parentSegment;
            }
        }

        /// <summary>
        /// Gets or sets the geometrical propagation model used by the scattering solver.
        /// </summary>
        public GeometricalPropagationModel? GeometricalPropagationModel { get; set; }

        /// <summary> Gets or sets the configuration options for the scattering solver. </summary>
        public ScatteringSolverOptions? ScatteringSolverOptions { get; set; }

        /// <summary> Gets a cloned list of scattering profiles, filtering out any null entries. </summary>
        public List<IScatteringProfile>? ScatteringProfiles
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(scatteringProfiles);
            }
        }

        /// <summary>
        /// Executes the solving operation.
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

            if (tuples == null || tuples.Count == 0)
            {
                return false;
            }

            scatteringProfiles = [];

            List<IScatteringObject>? scatteringObjects = GeometricalPropagationModel.GetScatteringObjects<IScatteringObject>();

            List<Triangle3> triangle3s = [];
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

                    List<Triangle3>? triangle3s_Temp = DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(mesh3D_ScatteringObject, true);
                    if (triangle3s_Temp == null)
                    {
                        continue;
                    }

                    foreach (Triangle3 triangle3 in triangle3s_Temp)
                    {
                        triangle3s.Add(triangle3);
                        references.Add(reference);
                    }

                    if (mesh3D_ScatteringObject.GetBoundingBox() is BoundingBox3D boundingBox3D)
                    {
                        boundingBox3Ds.Add(boundingBox3D);
                    }
                }
            }

            if (triangle3s == null || triangle3s.Count == 0)
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

            GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return false;
            }

            ReadOnlyBuffer<Triangle3> readOnlyBuffer_Triangle3s = graphicsDevice.AllocateReadOnlyBuffer(triangle3s.ToArray());

            List<Line3> line3s_Temp = [];
            foreach (Tuple<IAntenna, IAntenna, IMultipathPowerDelayProfile> tuple in tuples)
            {
                if (tuple.Item1?.Location?.ToComputeSharp() is not Coordinate3 point_1 || tuple.Item2?.Location?.ToComputeSharp() is not Coordinate3 point_2)
                {
                    continue;
                }

                line3s_Temp.Add(new Line3(new DiGi.ComputeSharp.Core.Classes.Bool(true), point_1, point_2));
            }

            List<bool>? intersects = DiGi.ComputeSharp.Spatial.Query.Intersect(graphicsDevice, line3s_Temp, readOnlyBuffer_Triangle3s, false, false);

            if (intersects is null)
            {
                return false;
            }

            for (int i = 0; i < tuples.Count; i++)
            {
                IAntenna antenna_1 = tuples[i].Item1;
                IAntenna antenna_2 = tuples[i].Item2;

                bool visible = !intersects[i];

                IMultipathPowerDelayProfile multipathPowerDelayProfile = tuples[i].Item3;

                ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile = multipathPowerDelayProfile is ISimpleMultipathPowerDelayProfile profile ? profile : ((IComplexMultipathPowerDelayProfile)multipathPowerDelayProfile).GetSimpleMultipathPowerDelay(visible);

                HashSet<double>? delays = simpleMultipathPowerDelayProfile?.Delays;
                if (delays == null || delays.Count == 0)
                {
                    continue;
                }

                SortedDictionary<double, Tuple<Ellipsoid, Mesh3D, List<Triangle3>?>?> sortedDictionary = [];
                foreach (double delay in delays)
                {
                    if (double.IsNaN(delay))
                    {
                        continue;
                    }

                    sortedDictionary[delay] = null;
                }

                Parallel.ForEach(sortedDictionary.Keys, delay =>
                //foreach (double delay in delays)
                {
                    Ellipsoid? ellipsoid = Create.Ellipsoid(antenna_1, antenna_2, delay, tolerance);
                    if (ellipsoid == null)
                    {
                        return;
                        //continue;
                    }

                    Mesh3D? mesh3D = ellipsoid.Mesh3D(angleFactor);
                    if (mesh3D == null)
                    {
                        return;
                        //continue;
                    }

                    List<Triangle3D>? triangle3Ds_Ellipsoid = mesh3D.GetTriangles();
                    if (triangle3Ds_Ellipsoid == null || triangle3Ds_Ellipsoid.Count == 0)
                    {
                        return;
                        //continue;
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

                    sortedDictionary[delay] = new Tuple<Ellipsoid, Mesh3D, List<Triangle3>?>(ellipsoid, mesh3D, DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(triangle3Ds_Ellipsoid, true));
                }
                );

                List<Scattering> scatterings = [];

                Coordinate3? location_1 = antenna_1?.Location?.ToComputeSharp();
                if (location_1 is null)
                {
                    return false;
                }

                Coordinate3? location_2 = antenna_2?.Location?.ToComputeSharp();
                if (location_2 is null)
                {
                    return false;
                }

                foreach (KeyValuePair<double, Tuple<Ellipsoid, Mesh3D, List<Triangle3>?>?> keyValuePair in sortedDictionary)
                {
                    double delay = keyValuePair.Key;

                    List<Triangle3>? triangle3s_Ellipsoid = keyValuePair.Value?.Item3;
                    if (triangle3s_Ellipsoid == null || triangle3s_Ellipsoid.Count == 0)
                    {
                        scatterings.Add(new Scattering(delay));
                        continue;
                    }

                    List<ScatteringPointGroup> scatteringPointGroups = [];

                    List<Point3D> points = [];
                    IEnumerable<Triangle3Intersection>? triangle3Interscetions = DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(graphicsDevice, triangle3s_Ellipsoid, readOnlyBuffer_Triangle3s, tolerance);
                    if (triangle3Interscetions != null)
                    {
                        List<Line3> line3s = [];
                        foreach (Triangle3Intersection triangle3Intersection in triangle3Interscetions)
                        {
                            IGeometry3[]? geometry3s = triangle3Intersection.GetIntersectionGeometries();
                            if (geometry3s == null)
                            {
                                continue;
                            }

                            foreach (IGeometry3 geometry3 in geometry3s)
                            {
                                if (geometry3 is Triangle3 triangle3)
                                {
                                    line3s.AddRange(triangle3.GetLines());
                                }
                                else if (geometry3 is Line3 line3)
                                {
                                    line3s.Add(line3);
                                }
                            }
                        }

                        if (line3s != null && line3s.Count != 0)
                        {
                            List<CandidatePoint> candidates_First = [];

                            foreach (Line3 line3 in line3s)
                            {
                                if (DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(line3) is not Segment3D segment3D)
                                {
                                    continue;
                                }

                                List<Coordinate3>? coordinate3s = DiGi.ComputeSharp.Spatial.Create.Coordinate3s(line3, LineAlignment.Center, pointDensityFactor, true, tolerance);
                                if (coordinate3s == null)
                                {
                                    continue;
                                }

                                foreach (Coordinate3 coordinate3 in coordinate3s)
                                {
                                    Line3 line3_Temp = new(new DiGi.ComputeSharp.Core.Classes.Bool(true), location_1.Value, coordinate3);
                                    candidates_First.Add(new CandidatePoint(line3_Temp, coordinate3, segment3D));
                                }
                            }

                            if (candidates_First.Count != 0)
                            {
                                List<bool>? intersects_Temp = DiGi.ComputeSharp.Spatial.Query.Intersect(graphicsDevice, candidates_First.ConvertAll(x => x.LineToLoc), readOnlyBuffer_Triangle3s, false, false);
                                if (intersects_Temp != null && intersects_Temp.Count != 0)
                                {
                                    List<CandidatePoint> candidates_Second = [];
                                    for (int j = 0; j < intersects_Temp.Count; j++)
                                    {
                                        if (intersects_Temp[j])
                                        {
                                            continue;
                                        }

                                        CandidatePoint candidate_First = candidates_First[j];
                                        Line3 line3_Temp = new(new DiGi.ComputeSharp.Core.Classes.Bool(true), location_2.Value, candidate_First.Point);
                                        candidates_Second.Add(new CandidatePoint(line3_Temp, candidate_First.Point, candidate_First.ParentSegment));
                                    }

                                    if (candidates_Second.Count != 0)
                                    {
                                        intersects_Temp = DiGi.ComputeSharp.Spatial.Query.Intersect(graphicsDevice, candidates_Second.ConvertAll(x => x.LineToLoc), readOnlyBuffer_Triangle3s, false, false);
                                        if (intersects_Temp != null && intersects_Temp.Count != 0)
                                        {
                                            List<CandidatePoint> candidates_Visible = [];
                                            for (int j = 0; j < intersects_Temp.Count; j++)
                                            {
                                                if (intersects_Temp[j])
                                                {
                                                    continue;
                                                }

                                                candidates_Visible.Add(candidates_Second[j]);
                                            }

                                            if (candidates_Visible.Count != 0)
                                            {
                                                List<Coordinate3> coordinate3s_Visible = candidates_Visible.ConvertAll(x => x.Point);
                                                List<int>? indexes = DiGi.ComputeSharp.Spatial.Query.Inside(graphicsDevice, coordinate3s_Visible, readOnlyBuffer_Triangle3s);
                                                if (indexes != null && indexes.Count != 0)
                                                {
                                                    Dictionary<string, List<CandidatePoint>> candidatesByReference = [];
                                                    for (int j = 0; j < candidates_Visible.Count; j++)
                                                    {
                                                        int index = indexes[j];
                                                        CandidatePoint candidate_Visible = candidates_Visible[j];

                                                        string reference = index == -1 ? string.Empty : references[index];
                                                        reference ??= string.Empty;

                                                        if (!candidatesByReference.TryGetValue(reference, out List<CandidatePoint>? points_Temp) || points_Temp == null)
                                                        {
                                                            points_Temp = [];
                                                            candidatesByReference[reference] = points_Temp;
                                                        }

                                                        points_Temp.Add(candidate_Visible);
                                                    }

                                                    foreach (KeyValuePair<string, List<CandidatePoint>> keyValuePair_Temp in candidatesByReference)
                                                    {
                                                        string reference = keyValuePair_Temp.Key;
                                                        List<CandidatePoint> candidates_Ref = keyValuePair_Temp.Value;

                                                        List<Segment3D> segments = [];
                                                        foreach (CandidatePoint candidate in candidates_Ref)
                                                        {
                                                            if (!segments.Contains(candidate.ParentSegment))
                                                            {
                                                                segments.Add(candidate.ParentSegment);
                                                            }
                                                        }

                                                        List<List<Segment3D>> components = GroupSegmentsIntoComponents(segments, tolerance);
                                                        foreach (List<Segment3D> component in components)
                                                        {
                                                            List<Point3D> pointsInComponent = [];
                                                            foreach (CandidatePoint candidate in candidates_Ref)
                                                            {
                                                                if (component.Contains(candidate.ParentSegment))
                                                                {
                                                                    if (DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(candidate.Point) is Point3D point3D)
                                                                    {
                                                                        pointsInComponent.Add(point3D);
                                                                    }
                                                                }
                                                            }

                                                            if (pointsInComponent.Count > 0)
                                                            {
                                                                scatteringPointGroups.Add(new ScatteringPointGroup(reference, pointsInComponent));
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    scatterings.Add(new Scattering(delay, scatteringPointGroups));
                }

                ScatteringProfile scatteringProfile = new(visible, antenna_1?.Location, antenna_2?.Location, scatterings);
                GeometricalPropagationModel.Assign(scatteringProfile, antenna_1, antenna_2);
                GeometricalPropagationModel.Assign(scatteringProfile, multipathPowerDelayProfile);
                scatteringProfiles.Add(scatteringProfile);
            }

            return true;
        }
    }
}
