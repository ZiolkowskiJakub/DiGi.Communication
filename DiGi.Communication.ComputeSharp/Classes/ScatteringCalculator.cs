using ComputeSharp;
using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.ComputeSharp.Geometry.Spatial;
using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.ComputeSharp.Spatial.Enums;
using DiGi.ComputeSharp.Spatial.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.ComputeSharp.Classes
{
    public class ScatteringCalculator : ICommunicationObject, ICalculator
    {
        private List<IScatteringProfile> scatteringProfiles;
        
        public GeometricalPropagationModel GeometricalPropagationModel { get; set; }
        
        public ScatteringCalculatorOptions ScatteringCalculatorOptions { get; set; }
        
        public List<IScatteringProfile> ScatteringProfiles
        {
            get
            {
                return Core.Query.Clone(scatteringProfiles);
            }
        }

        public bool Calculate()
        {
            scatteringProfiles = null;

            if (ScatteringCalculatorOptions == null || GeometricalPropagationModel == null)
            {
                return false;
            }

            List<IMultipathPowerDelayProfile> multipathPowerDelayProfiles = GeometricalPropagationModel.GetMultipathPowerDelayProfiles<IMultipathPowerDelayProfile>();
            if (multipathPowerDelayProfiles == null || multipathPowerDelayProfiles.Count == 0)
            {
                return false;
            }

            double tolerance = ScatteringCalculatorOptions.Tolerance;

            double angleFactor = ScatteringCalculatorOptions.AngleFactor;

            double pointDensityFactor = ScatteringCalculatorOptions.PointDensityFactor;

            List<Tuple<IAntenna, IAntenna, IMultipathPowerDelayProfile>> tuples = new List<Tuple<IAntenna, IAntenna, IMultipathPowerDelayProfile>>();
            foreach (IMultipathPowerDelayProfile multipathPowerDelayProfile in multipathPowerDelayProfiles)
            {
                List<IAntenna> antennas_1 = GeometricalPropagationModel.GetAntennas<IAntenna>(multipathPowerDelayProfile);
                if (antennas_1 != null)
                {
                    foreach (IAntenna antenna_1 in antennas_1)
                    {
                        List<IAntenna> antennas_2 = GeometricalPropagationModel.GetAntennas<IAntenna>(multipathPowerDelayProfile, antenna_1);
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
                tuples.RemoveAll(x => !x.Item1.Functions.Contains(Enums.Function.Receiver) && !x.Item2.Functions.Contains(Enums.Function.Receiver));
                tuples.RemoveAll(x => !x.Item1.Functions.Contains(Enums.Function.Transmitter) && !x.Item2.Functions.Contains(Enums.Function.Transmitter));
            }

            if (tuples == null || tuples.Count == 0)
            {
                return false;
            }

            scatteringProfiles = new List<IScatteringProfile>();

            List<IScatteringObject> scatteringObjects = GeometricalPropagationModel.GetScatteringObjects<IScatteringObject>();

            List<Triangle3> triangle3s = new List<Triangle3>();
            List<string> references = new List<string>();
            List<BoundingBox3D> boundingBox3Ds = new List<BoundingBox3D>();

            if (scatteringObjects != null)
            {
                foreach (IScatteringObject scatteringObject in scatteringObjects)
                {
                    Mesh3D mesh3D_ScatteringObject = scatteringObject?.Mesh3D;
                    if (mesh3D_ScatteringObject == null)
                    {
                        continue;
                    }

                    string reference = scatteringObject.Reference;

                    List<Triangle3> triangle3s_Temp = DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(mesh3D_ScatteringObject, true);
                    if (triangle3s_Temp == null)
                    {
                        continue;
                    }

                    foreach (Triangle3 triangle3 in triangle3s_Temp)
                    {
                        triangle3s.Add(triangle3);
                        references.Add(reference);
                    }

                    BoundingBox3D boundingBox3D_ScatteringObject = mesh3D_ScatteringObject.GetBoundingBox();
                    boundingBox3Ds.Add(boundingBox3D_ScatteringObject);
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

                    ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile = multipathPowerDelayProfile is ISimpleMultipathPowerDelayProfile ? (ISimpleMultipathPowerDelayProfile)multipathPowerDelayProfile : ((IComplexMultipathPowerDelayProfile)multipathPowerDelayProfile).GetSimpleMultipathPowerDelay(visible);

                    HashSet<double> delays = simpleMultipathPowerDelayProfile?.Delays;
                    if (delays == null || delays.Count == 0)
                    {
                        continue;
                    }

                    List<Scattering> scatterings = new List<Scattering>();
                    foreach (double delay in delays)
                    {
                        scatterings.Add(new Scattering(delay));
                    }

                    ScatteringProfile scatteringProfile = new ScatteringProfile(visible, antenna_1.Location, antenna_2.Location, scatterings);
                    GeometricalPropagationModel.Assign(scatteringProfile, antenna_1, antenna_2);
                    GeometricalPropagationModel.Assign(scatteringProfile, multipathPowerDelayProfile);
                    scatteringProfiles.Add(scatteringProfile);
                }

                return true;
            }

            GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return false;
            }

            ReadOnlyBuffer<Triangle3> readOnlyBuffer_Triangle3s = graphicsDevice.AllocateReadOnlyBuffer(triangle3s.ToArray());

            List<Line3> lines = tuples.ConvertAll(x => new Line3(new DiGi.ComputeSharp.Core.Classes.Bool(true), x.Item1.Location.ToComputeSharp(), x.Item2.Location.ToComputeSharp()));
            List<bool> intersects = DiGi.ComputeSharp.Spatial.Query.Intersect(graphicsDevice, lines, readOnlyBuffer_Triangle3s, false, false, tolerance);

            for (int i = 0; i < tuples.Count; i++)
            {
                IAntenna antenna_1 = tuples[i].Item1;
                IAntenna antenna_2 = tuples[i].Item2;

                bool visible = !intersects[i];

                IMultipathPowerDelayProfile multipathPowerDelayProfile = tuples[i].Item3;

                ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile = multipathPowerDelayProfile is ISimpleMultipathPowerDelayProfile ? (ISimpleMultipathPowerDelayProfile)multipathPowerDelayProfile : ((IComplexMultipathPowerDelayProfile)multipathPowerDelayProfile).GetSimpleMultipathPowerDelay(visible);

                HashSet<double> delays = simpleMultipathPowerDelayProfile?.Delays;
                if (delays == null || delays.Count == 0)
                {
                    continue;
                }

                SortedDictionary<double, Tuple<Ellipsoid, Mesh3D, List<Triangle3>>> sortedDictionary = new SortedDictionary<double, Tuple<Ellipsoid, Mesh3D, List<Triangle3>>>();
                foreach (double delay in delays)
                {
                    if(double.IsNaN(delay))
                    {
                        continue;
                    }

                    sortedDictionary[delay] = null;
                }

                Parallel.ForEach(sortedDictionary.Keys, delay => 
                //foreach (double delay in delays)
                {
                    Ellipsoid ellipsoid = Create.Ellipsoid(antenna_1, antenna_2, delay, tolerance);
                    if (ellipsoid == null)
                    {
                        return;
                        //continue;
                    }

                    Mesh3D mesh3D = ellipsoid.Mesh3D(angleFactor);
                    if (mesh3D == null)
                    {
                        return;
                        //continue;
                    }

                    List<Triangle3D> triangle3Ds_Ellipsoid = mesh3D.GetTriangles();
                    if (triangle3Ds_Ellipsoid == null || triangle3Ds_Ellipsoid.Count == 0)
                    {
                        return;
                        //continue;
                    }

                    for (int j = triangle3Ds_Ellipsoid.Count - 1; j >= 0; j--)
                    {
                        Triangle3D triangle3D = triangle3Ds_Ellipsoid[j];

                        BoundingBox3D boundingBox3D_Triangle3D = triangle3D.GetBoundingBox();

                        int index = boundingBox3Ds.FindIndex(x => x.InRange(boundingBox3D_Triangle3D, tolerance));
                        if (index >= 0)
                        {
                            continue;
                        }

                        triangle3Ds_Ellipsoid.RemoveAt(j);
                    }

                    sortedDictionary[delay] = new Tuple<Ellipsoid, Mesh3D, List<Triangle3>>(ellipsoid, mesh3D, DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(triangle3Ds_Ellipsoid, true));
                }
                );

                List<Scattering> scatterings = new List<Scattering>();

                Coordinate3 location_1 = antenna_1.Location.ToComputeSharp();
                Coordinate3 location_2 = antenna_2.Location.ToComputeSharp();

                foreach (KeyValuePair<double, Tuple<Ellipsoid, Mesh3D, List<Triangle3>>> keyValuePair in sortedDictionary)
                {
                    double delay = keyValuePair.Key;

                    List<Triangle3> triangle3s_Ellipsoid = keyValuePair.Value.Item3;
                    if (triangle3s_Ellipsoid == null || triangle3s_Ellipsoid.Count == 0)
                    {
                        scatterings.Add(new Scattering(delay));
                        continue;
                    }

                    List<ScatteringPointGroup> scatteringPointGroups = new List<ScatteringPointGroup>();

                    List<Point3D> points = new List<Point3D>();
                    IEnumerable<Triangle3Intersection> triangle3Interscetions = DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(graphicsDevice, triangle3s_Ellipsoid, readOnlyBuffer_Triangle3s, tolerance);
                    if (triangle3Interscetions != null)
                    {
                        List<Line3> line3s = new List<Line3>();
                        foreach (Triangle3Intersection triangle3Intersection in triangle3Interscetions)
                        {
                            IGeometry3[] geometry3s = triangle3Intersection.GetIntersectionGeometries();
                            if (geometry3s == null)
                            {
                                continue;
                            }

                            foreach (IGeometry3 geometry3 in geometry3s)
                            {
                                if (geometry3 is Triangle3)
                                {
                                    line3s.AddRange(((Triangle3)geometry3).GetLines());
                                }
                                else if (geometry3 is Line3)
                                {
                                    line3s.Add((Line3)geometry3);
                                }
                            }
                        }

                        if (line3s != null && line3s.Count != 0)
                        {
                            List<Segment3D> intersectionSegment3Ds = new List<Segment3D>();

                            List<Tuple<Line3, Coordinate3>> tuples_1 = new List<Tuple<Line3, Coordinate3>>();

                            foreach (Line3 line3 in line3s)
                            {
                                intersectionSegment3Ds.Add(DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(line3));

                                List<Coordinate3> coordinate3s = DiGi.ComputeSharp.Spatial.Create.Coordinate3s(line3, LineAlignment.Center, pointDensityFactor, true, tolerance);
                                if (coordinate3s == null)
                                {
                                    continue;
                                }

                                foreach (Coordinate3 coordinate3 in coordinate3s)
                                {
                                    Line3 line3_Temp = new Line3(new DiGi.ComputeSharp.Core.Classes.Bool(true), location_1, coordinate3);

                                    tuples_1.Add(new Tuple<Line3, Coordinate3>(line3_Temp, coordinate3));
                                }
                            }

                            if (tuples_1 != null && tuples_1.Count != 0)
                            {
                                List<bool> intersects_Temp = DiGi.ComputeSharp.Spatial.Query.Intersect(graphicsDevice, tuples_1.ConvertAll(x => x.Item1), readOnlyBuffer_Triangle3s, false, false, tolerance);
                                if (intersects_Temp != null && intersects_Temp.Count != 0)
                                {
                                    List<Tuple<Line3, Coordinate3>> tuples_2 = new List<Tuple<Line3, Coordinate3>>();
                                    for (int j = 0; j < intersects_Temp.Count; j++)
                                    {
                                        if (intersects_Temp[j])
                                        {
                                            continue;
                                        }

                                        Coordinate3 coordinate3 = tuples_1[j].Item2;

                                        Line3 line3_Temp = new Line3(new DiGi.ComputeSharp.Core.Classes.Bool(true), location_2, coordinate3);

                                        tuples_2.Add(new Tuple<Line3, Coordinate3>(line3_Temp, coordinate3));
                                    }

                                    if (tuples_2 != null && tuples_2.Count != 0)
                                    {
                                        intersects_Temp = DiGi.ComputeSharp.Spatial.Query.Intersect(graphicsDevice, tuples_2.ConvertAll(x => x.Item1), readOnlyBuffer_Triangle3s, false, false, tolerance);
                                        if (intersects_Temp != null && intersects_Temp.Count != 0)
                                        {
                                            List<Coordinate3> coordinate3s = new List<Coordinate3>();
                                            for (int j = 0; j < intersects_Temp.Count; j++)
                                            {
                                                if (intersects_Temp[j])
                                                {
                                                    continue;
                                                }

                                                coordinate3s.Add(tuples_2[j].Item2);
                                            }

                                            if (coordinate3s != null && coordinate3s.Count != 0)
                                            {
                                                List<int> indexes = DiGi.ComputeSharp.Spatial.Query.Inside(graphicsDevice, coordinate3s, readOnlyBuffer_Triangle3s, tolerance);
                                                if (indexes != null && indexes.Count != 0)
                                                {
                                                    Dictionary<string, List<Coordinate3>> dictionary = new Dictionary<string, List<Coordinate3>>();
                                                    for (int j = 0; j < coordinate3s.Count; j++)
                                                    {
                                                        int index = indexes[j];
                                                        Coordinate3 point = coordinate3s[j];

                                                        string reference = index == -1 ? string.Empty : references[index];
                                                        if (reference == null)
                                                        {
                                                            reference = string.Empty;
                                                        }

                                                        if (!dictionary.TryGetValue(reference, out List<Coordinate3> points_Temp) || points_Temp == null)
                                                        {
                                                            points_Temp = new List<Coordinate3>();
                                                            dictionary[reference] = points_Temp;
                                                        }

                                                        points_Temp.Add(point);
                                                    }

                                                    foreach (KeyValuePair<string, List<Coordinate3>> keyValuePair_Temp in dictionary)
                                                    {
                                                        scatteringPointGroups.Add(new ScatteringPointGroup(keyValuePair_Temp.Key, keyValuePair_Temp.Value.ConvertAll(x => DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(x))));
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

                ScatteringProfile scatteringProfile = new ScatteringProfile(visible, antenna_1.Location, antenna_2.Location, scatterings);
                GeometricalPropagationModel.Assign(scatteringProfile, antenna_1, antenna_2);
                GeometricalPropagationModel.Assign(scatteringProfile, multipathPowerDelayProfile);
                scatteringProfiles.Add(scatteringProfile);
            }

            return true;
        }
    }
}
