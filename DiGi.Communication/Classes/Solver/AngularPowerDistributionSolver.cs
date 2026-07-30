using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Provides functionality to solve the distribution of angular power based on a set of defined angular power distribution profiles and solver options.
    /// </summary>
    public class AngularPowerDistributionSolver : ICommunicationObject, ISolver
    {
        private List<IAngularPowerDistributionProfile>? angularPowerDistributionProfiles;

        /// <summary> Gets or sets the configuration options for the angular power distribution solver. </summary>
        public AngularPowerDistributionSolverOptions? AngularPowerDistributionSolverOptions { get; set; }

        /// <summary> Gets the list of angular power distribution profiles, filtered to remove null entries and cloned to ensure data integrity. </summary>
        public List<IAngularPowerDistributionProfile>? AngularPowerDistributionProfiles
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(angularPowerDistributionProfiles);
            }
        }

        /// <summary>
        /// Gets or sets the geometrical propagation model used by the solver to calculate the angular power distribution.
        /// </summary>
        public GeometricalPropagationModel? GeometricalPropagationModel { get; set; }

        /// <summary>
        /// Executes the solving operation for the angular power distribution.
        /// </summary>
        /// <returns><c>true</c> if the solver successfully executed; otherwise, <c>false</c>.</returns>
        public bool Solve()
        {
            angularPowerDistributionProfiles = null;

            if (GeometricalPropagationModel == null || AngularPowerDistributionSolverOptions == null)
            {
                return false;
            }

            List<IScatteringProfile>? scatteringProfiles = GeometricalPropagationModel.GetScatteringProfiles<IScatteringProfile>();
            if (scatteringProfiles == null || scatteringProfiles.Count == 0)
            {
                return false;
            }

            List<IScatteringObject>? scatteringObjects = GeometricalPropagationModel.GetScatteringObjects<IScatteringObject>();

            angularPowerDistributionProfiles = [];

            foreach (IScatteringProfile scatteringProfile in scatteringProfiles)
            {
                IMultipathPowerDelayProfile? multipathPowerDelayProfile = GeometricalPropagationModel.GetMultipathPowerDelayProfile<IMultipathPowerDelayProfile>(scatteringProfile);
                if (multipathPowerDelayProfile == null)
                {
                    continue;
                }

                ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile = null;
                if (multipathPowerDelayProfile is IComplexMultipathPowerDelayProfile complexMultipathPowerDelayProfile)
                {
                    simpleMultipathPowerDelayProfile = complexMultipathPowerDelayProfile.GetSimpleMultipathPowerDelay(scatteringProfile.Visible);
                }
                else
                {
                    simpleMultipathPowerDelayProfile = multipathPowerDelayProfile as ISimpleMultipathPowerDelayProfile;
                }

                if (simpleMultipathPowerDelayProfile == null)
                {
                    continue;
                }

                List<IAntenna>? antennas = GeometricalPropagationModel.GetAntennas<IAntenna>(scatteringProfile);
                if (antennas == null || antennas.Count != 2)
                {
                    continue;
                }

                IEnumerable<Scattering>? scatterings = scatteringProfile.Scatterings;
                if (scatterings == null)
                {
                    continue;
                }

                double frequency = AngularPowerDistributionSolverOptions.Frequency;

                List<Tuple<IScatteringProfile, IAntenna, IAngularPowerDistributionProfile>> tuples = [];
                foreach (IAntenna antenna in antennas)
                {
                    HashSet<Function>? functions = antenna?.Functions;
                    if (functions == null || !functions.Contains(Function.Receiver))
                    {
                        continue;
                    }

                    Point3D? location_Receiver = antenna?.Location;
                    if (location_Receiver == null)
                    {
                        continue;
                    }

                    IAntenna antenna_Transmitter = antennas.Find(x => x.Guid != antenna!.Guid && x.Functions is HashSet<Function> functions_Temp && functions_Temp.Contains(Function.Transmitter));
                    if(antenna_Transmitter is null)
                    {
                        continue;
                    }

                    Point3D? location_Transmitter = antenna_Transmitter?.Location;
                    if (location_Transmitter == null)
                    {
                        continue;
                    }

                    int count = scatterings.Count();

                    List<AngularPowerDistribution> angularPowerDistributions = [];

                    for (int i = 0; i < count; i++)
                    {
                        Scattering scattering = scatterings.ElementAt(i);
                        if (scattering == null)
                        {
                            continue;
                        }

                        double delay = scattering.Delay;

                        double power = simpleMultipathPowerDelayProfile.GetPower(delay);
                        if (double.IsNaN(power) || power == 0)
                        {
                            continue;
                        }

                        SphericalDistributionScatteringHitCollection sphericalDistributionScatteringHitCollection = new();

                        List<ScatteringPointGroup>? scatteringPointGroups = scattering.ScatteringPointGroups;
                        if (scatteringPointGroups != null && scatteringPointGroups.Count != 0)
                        {
                            Dictionary<string, List<Point3D>> dictionary = [];
                            foreach (ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
                            {
                                string? reference = scatteringPointGroup?.Reference;
                                if (string.IsNullOrWhiteSpace(reference))
                                {
                                    continue;
                                }

                                List<Point3D>? point3Ds = scatteringPointGroup?.Points;
                                if (point3Ds == null)
                                {
                                    continue;
                                }

                                foreach(Point3D point3D in point3Ds)
                                {
                                    if (new Vector3D(point3D, location_Receiver).Unit is Vector3D vector3D)
                                    {
                                        Ray3D ray3D = new(location_Receiver.GetMoved(vector3D.GetInversed()), vector3D);

                                        ScatteringHit scatteringHit = new(reference, ray3D);
                                        double azimuth = Math.Atan2(vector3D.Y, vector3D.X);
                                        if (azimuth < 0)
                                        {
                                            azimuth += Math.PI * 2;
                                        }

                                        double elevation = Math.Acos(vector3D.Z / vector3D.Length);
                                        sphericalDistributionScatteringHitCollection.AddValue(azimuth, elevation, scatteringHit);
                                    }
                                }
                            }
                        }

                        angularPowerDistributions.Add(new AngularPowerDistribution(delay, sphericalDistributionScatteringHitCollection));
                    }

                    tuples.Add(new Tuple<IScatteringProfile, IAntenna, IAngularPowerDistributionProfile>(scatteringProfile, antenna!, new AngularPowerDistributionProfile(location_Receiver, frequency, angularPowerDistributions)));
                }

                foreach (Tuple<IScatteringProfile, IAntenna, IAngularPowerDistributionProfile> tuple in tuples)
                {
                    GeometricalPropagationModel.Assign(tuple.Item3, tuple.Item2);
                    angularPowerDistributionProfiles.Add(tuple.Item3);
                }
            }

            return true;
        }
    }
}