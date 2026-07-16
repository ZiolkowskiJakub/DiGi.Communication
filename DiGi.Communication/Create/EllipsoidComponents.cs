using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace DiGi.Communication
{
    public static partial class Create
    {
        /// <summary>
        /// Stage I of the multi-ellipsoidal model: determines the power components P_n from the individual propagation ellipsoids. Each mesh cell is assigned to the ellipsoid with the nearest delay, the complex reflection coefficients are weighted by the omnidirectional antenna characteristics and summed per ellipsoid.
        /// </summary>
        /// <param name="propagationModel">Input data of the multi-ellipsoidal propagation model.</param>
        /// <returns>Ellipsoid components ordered by delay or <see langword="null"/> for invalid input.</returns>
        public static List<EllipsoidComponent>? EllipsoidComponents(this PropagationModel? propagationModel)
        {
            if (propagationModel == null || propagationModel.Distance <= 0 || propagationModel.Frequency <= 0)
            {
                return null;
            }

            SimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile = propagationModel.SimpleMultipathPowerDelayProfile;
            if (simpleMultipathPowerDelayProfile == null)
            {
                return null;
            }

            HashSet<double>? delays = simpleMultipathPowerDelayProfile.Delays;
            if (delays == null || delays.Count == 0)
            {
                return null;
            }

            AntennaCharacteristic? transmittingCharacteristic = propagationModel.TransmittingOmnidirectionalCharacteristic;
            AntennaCharacteristic? receivingCharacteristic = propagationModel.ReceivingOmnidirectionalCharacteristic;
            if (transmittingCharacteristic == null || receivingCharacteristic == null)
            {
                return null;
            }

            double distance = propagationModel.Distance;
            double wavelength = Query.Wavelength(propagationModel.Frequency);

            List<double> orderedDelays = [.. delays.OrderBy(x => x)];

            List<List<RayContribution>> rayContributionsList = [];
            for (int i = 0; i < orderedDelays.Count; i++)
            {
                rayContributionsList.Add([]);
            }

            if (propagationModel.MeshCells != null)
            {
                foreach (MeshCell meshCell in propagationModel.MeshCells)
                {
                    double delay = meshCell.Delay(distance);
                    if (double.IsNaN(delay))
                    {
                        continue;
                    }

                    double incidenceAngle = meshCell.IncidenceAngle();
                    if (double.IsNaN(incidenceAngle))
                    {
                        continue;
                    }

                    Point3D? center = meshCell.Center;
                    MaterialProperties? materialProperties = meshCell.MaterialProperties;
                    if (center == null || materialProperties == null)
                    {
                        continue;
                    }

                    Vector3D vector3D_Transmitter = new(center.X, center.Y, center.Z);
                    Vector3D vector3D_Receiver = new(center.X - distance, center.Y, center.Z);

                    double thetaTransmitter = vector3D_Transmitter.Theta();
                    double thetaReceiver = vector3D_Receiver.Theta();
                    if (double.IsNaN(thetaTransmitter) || double.IsNaN(thetaReceiver))
                    {
                        continue;
                    }

                    double phiTransmitter = vector3D_Transmitter.Phi();
                    double phiReceiver = vector3D_Receiver.Phi();

                    int index = -1;
                    double difference = double.MaxValue;
                    for (int i = 0; i < orderedDelays.Count; i++)
                    {
                        double difference_Temp = Math.Abs(orderedDelays[i] - delay);
                        if (difference_Temp < difference)
                        {
                            difference = difference_Temp;
                            index = i;
                        }
                    }

                    Complex complexRelativePermittivity = materialProperties.ComplexRelativePermittivity(wavelength);
                    Complex reflectionCoefficient = Query.ReflectionCoefficient(complexRelativePermittivity, incidenceAngle, propagationModel.Polarization);

                    double transmittingGain = transmittingCharacteristic(thetaTransmitter, phiTransmitter);
                    double receivingGain = receivingCharacteristic(thetaReceiver, phiReceiver);

                    RayContribution rayContribution = new(incidenceAngle, phiReceiver, phiTransmitter, receivingGain, reflectionCoefficient, thetaReceiver, thetaTransmitter, transmittingGain, transmittingGain * receivingGain * reflectionCoefficient);

                    rayContributionsList[index].Add(rayContribution);
                }
            }

            List<EllipsoidComponent> result = [];
            for (int i = 0; i < orderedDelays.Count; i++)
            {
                double delay = orderedDelays[i];
                double fractionalPower = simpleMultipathPowerDelayProfile.GetPower(delay);
                List<RayContribution> rayContributions = rayContributionsList[i];

                Complex reflectionCoefficientSum = Complex.Zero;
                double referencePower = 0;
                foreach (RayContribution rayContribution in rayContributions)
                {
                    reflectionCoefficientSum += rayContribution.WeightedReflectionCoefficient;

                    double magnitude = rayContribution.WeightedReflectionCoefficient.Magnitude;
                    referencePower += magnitude * magnitude;
                }

                double power = reflectionCoefficientSum.Magnitude * reflectionCoefficientSum.Magnitude;

                EllipsoidComponent ellipsoidComponent = new(
                    delay,
                    0,
                    0,
                    fractionalPower,
                    power,
                    0,
                    rayContributions,
                    referencePower,
                    reflectionCoefficientSum,
                    Query.SemiMajorAxis(delay, distance),
                    Query.SemiMinorAxis(delay, distance));

                result.Add(ellipsoidComponent);
            }

            return result;
        }
    }
}