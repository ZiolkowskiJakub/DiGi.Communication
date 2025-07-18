using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Classes
{
    public class AngularPowerDistributionCalculator : ICommunicationObject, ICalculator
    {
        private List<IAngularPowerDistributionProfile> angularPowerDistributionProfiles;
        
        public AngularPowerDistributionCalculatorOptions AngularPowerDistributionCalculatorOptions { get; set; }

        public List<IAngularPowerDistributionProfile> AngularPowerDistributionProfiles
        {
            get
            {
                return Core.Query.Clone(angularPowerDistributionProfiles);
            }
        }

        public GeometricalPropagationModel GeometricalPropagationModel { get; set; }
        
        public bool Calculate()
        {
            angularPowerDistributionProfiles = null;

            if (GeometricalPropagationModel == null || AngularPowerDistributionCalculatorOptions == null)
            {
                return false;
            }

            List<IScatteringProfile> scatteringProfiles = GeometricalPropagationModel.GetScatteringProfiles<IScatteringProfile>();
            if (scatteringProfiles == null || scatteringProfiles.Count == 0)
            {
                return false;
            }

            List<IScatteringObject> scatteringObjects = GeometricalPropagationModel.GetScatteringObjects<IScatteringObject>();

            double tolerance = AngularPowerDistributionCalculatorOptions.Tolerance;

            int rayCount = AngularPowerDistributionCalculatorOptions.RayCount;

            angularPowerDistributionProfiles = new List<IAngularPowerDistributionProfile>();

            foreach (IScatteringProfile scatteringProfile in scatteringProfiles)
            {
                IMultipathPowerDelayProfile multipathPowerDelayProfile = GeometricalPropagationModel.GetMultipathPowerDelayProfile<IMultipathPowerDelayProfile>(scatteringProfile);
                if(multipathPowerDelayProfile == null)
                {
                    continue;
                }

                ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile = null;
                if(multipathPowerDelayProfile is IComplexMultipathPowerDelayProfile)
                {
                    simpleMultipathPowerDelayProfile = ((IComplexMultipathPowerDelayProfile)multipathPowerDelayProfile).GetSimpleMultipathPowerDelay(scatteringProfile.Visible);
                }
                else
                {
                    simpleMultipathPowerDelayProfile = multipathPowerDelayProfile as ISimpleMultipathPowerDelayProfile;
                }

                if(simpleMultipathPowerDelayProfile == null)
                {
                    continue;
                }

                List<IAntenna> antennas = GeometricalPropagationModel.GetAntennas<IAntenna>(scatteringProfile);
                if (antennas == null || antennas.Count < 2)
                {
                    continue;
                }

                IEnumerable<Scattering> scatterings = scatteringProfile.Scatterings;
                if (scatterings == null)
                {
                    continue;
                }

                List<Tuple<IScatteringProfile, IAntenna, IAngularPowerDistributionProfile>> tuples = new List<Tuple<IScatteringProfile, IAntenna, IAngularPowerDistributionProfile>>();
                foreach (IAntenna antenna in antennas)
                {
                    HashSet<Function> functions = antenna?.Functions;
                    if (functions == null || !functions.Contains(Function.Receiver))
                    {
                        continue;
                    }

                    Point3D location = antenna.Location;
                    if (location == null)
                    {
                        continue;
                    }

                    int count = scatterings.Count();

                    List<AngularPowerDistribution> angularPowerDistributions = new List<AngularPowerDistribution>();

                    for (int i = 0; i < count; i++)
                    {
                        Scattering scattering = scatterings.ElementAt(i);
                        if (scattering == null)
                        {
                            continue;
                        }

                        double delay = scattering.Delay;

                        double power = simpleMultipathPowerDelayProfile.GetPower(delay);
                        if(double.IsNaN(power) || power == 0)
                        {
                            continue;
                        }

                        List<Vector3D> vector3Ds = new List<Vector3D>();

                        List<ScatteringPointGroup> scatteringPointGroups = scattering.ScatteringPointGroups;
                        if(scatteringPointGroups != null && scatteringPointGroups.Count != 0)
                        {
                            Dictionary<string, List<Point3D>> dictionary = new Dictionary<string, List<Point3D>>();
                            foreach(ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
                            {
                                string reference = scatteringPointGroup?.Reference;
                                if(string.IsNullOrWhiteSpace(reference))
                                {
                                    continue;
                                }

                                List<Point3D> point3Ds = scatteringPointGroup.Points;
                                if(point3Ds == null)
                                {
                                    continue;
                                }

                                if(!dictionary.TryGetValue(reference, out List<Point3D> point3Ds_Temp) || point3Ds_Temp == null)
                                {
                                    point3Ds_Temp = new List<Point3D>();
                                    dictionary[reference] = point3Ds_Temp;
                                }

                                point3Ds_Temp.AddRange(point3Ds);
                            }

                            List<Tuple<List<Point3D>, double>> tuples_Point3Ds = new List<Tuple<List<Point3D>, double>>();
                            foreach(KeyValuePair<string, List<Point3D>> keyValuePair in dictionary)
                            {
                                List<Point3D> point3Ds = keyValuePair.Value;
                                if (point3Ds == null || point3Ds.Count < 2)
                                {
                                    continue;
                                }

                                Geometry.Spatial.Query.ExtremePoints(point3Ds, out Point3D point3D_1, out Point3D point3D_2);

                                double distance = point3D_1.Distance(point3D_2);

                                if (distance < tolerance)
                                {
                                    continue;
                                }

                                double scatteringCoefficient = 1;

                                IScatteringObject scatteringObject = scatteringObjects.Find(x => x.Reference == keyValuePair.Key);
                                if (scatteringObject != null)
                                {
                                    scatteringCoefficient = scatteringObject.ScatteringCoefficient;
                                }

                                double weight = distance * scatteringCoefficient;

                                Segment3D segment3D = new Segment3D(point3D_1, point3D_2);

                                List<Point3D> point3Ds_Temp = Geometry.Spatial.Create.Point3Ds(segment3D, rayCount);
                                if(point3Ds_Temp == null || point3Ds_Temp.Count == 0)
                                {
                                    continue;
                                }

                                List<Point3D> point3Ds_Closest = new List<Point3D>();
                                foreach (Point3D point3D_Temp in point3Ds_Temp)
                                {
                                    point3Ds_Closest.Add(point3D_Temp.ClosestPoint(point3Ds, out double distance_Temp));
                                }

                                tuples_Point3Ds.Add(new Tuple<List<Point3D>, double>(point3Ds_Closest, weight));
                            }

                            double total = tuples_Point3Ds.ConvertAll(x => x.Item2).Sum();

                            foreach(Tuple<List<Point3D>, double> tuple_Point3Ds in tuples_Point3Ds)
                            {
                                int count_Temp = tuple_Point3Ds.Item1.Count;

                                double length = (tuple_Point3Ds.Item2 / total) * power;

                                length /= count_Temp;

                                foreach(Point3D point3D in tuple_Point3Ds.Item1)
                                {
                                    vector3Ds.Add(new Vector3D(point3D, location).Unit * length);
                                }
                            }
                        }

                        angularPowerDistributions.Add(new AngularPowerDistribution(delay, vector3Ds));
                    }

                    tuples.Add(new Tuple<IScatteringProfile, IAntenna, IAngularPowerDistributionProfile>(scatteringProfile, antenna, new AngularPowerDistributionProfile(location, angularPowerDistributions)));
                }

                foreach(Tuple<IScatteringProfile, IAntenna, IAngularPowerDistributionProfile> tuple in tuples)
                {
                    GeometricalPropagationModel.Assign(tuple.Item3, tuple.Item2);
                    angularPowerDistributionProfiles.Add(tuple.Item3);
                }
            }

            return true;
        }
    }
}
