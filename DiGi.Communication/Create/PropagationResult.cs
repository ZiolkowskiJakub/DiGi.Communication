using DiGi.Communication.Classes;
using DiGi.Communication.Enums;
using System.Collections.Generic;

namespace DiGi.Communication
{
    public static partial class Create
    {
        /// <summary>
        /// Executes the full comparative analysis cascade of the multi-ellipsoidal propagation model directly from a geometrical propagation model. The geometrical input is first converted into the input data of the multi-ellipsoidal propagation model (see <see cref="Convert.ToPropagation_PropagationModel(GeometricalPropagationModel?, double, Polarization, MaterialProperties?, AntennaCharacteristic?, AntennaCharacteristic?, AntennaCharacteristic?, AntennaCharacteristic?, Dictionary{string, MaterialProperties}?)"/>) and afterwards the standard three stage cascade is executed.
        /// </summary>
        /// <param name="geometricalPropagationModel">Geometrical propagation model holding the antennas, the scattering objects and the multipath power delay profile.</param>
        /// <param name="frequency">Frequency f of the propagating electromagnetic wave [MHz].</param>
        /// <param name="polarization">Polarization type of the propagating electromagnetic wave.</param>
        /// <param name="materialProperties">Default electrical material properties applied to the mesh cells of the scattering objects.</param>
        /// <param name="receivingDirectionalCharacteristic">Normalized reception characteristic g(theta, phi) of the directional receiving antenna.</param>
        /// <param name="receivingOmnidirectionalCharacteristic">Normalized reception characteristic g_0(theta, phi) of the omnidirectional receiving antenna.</param>
        /// <param name="transmittingOmnidirectionalCharacteristic">Normalized radiation characteristic g_T0(theta, phi) of the omnidirectional transmitting antenna.</param>
        /// <param name="materialPropertiesDictionary">Optional electrical material properties per scattering object keyed by the scattering object reference. Scattering objects without an entry use the default material properties.</param>
        /// <returns>Result of the comparative analysis or <see langword="null"/> for invalid input.</returns>
        public static PropagationResult? PropagationResult(this GeometricalPropagationModel? geometricalPropagationModel, double frequency, Polarization polarization, MaterialProperties? materialProperties, AntennaCharacteristic? receivingDirectionalCharacteristic, AntennaCharacteristic? receivingOmnidirectionalCharacteristic, AntennaCharacteristic? transmittingOmnidirectionalCharacteristic, Dictionary<string, MaterialProperties>? materialPropertiesDictionary = null)
        {
            PropagationModel? propagationModel = geometricalPropagationModel.ToPropagation_PropagationModel(frequency, polarization, materialProperties, receivingDirectionalCharacteristic, receivingOmnidirectionalCharacteristic, null, transmittingOmnidirectionalCharacteristic, materialPropertiesDictionary);

            return propagationModel?.PropagationResult();
        }

        /// <summary>
        /// Executes the full comparative analysis cascade of the multi-ellipsoidal propagation model.
        /// <para>Stage I: determines the power components P_n from the individual propagation ellipsoids.</para>
        /// <para>Stage II: assigns the corrected power p_nkl = w_0n * w_Pn * g_T0kl * g_0kl * |Gamma_kl|^2 / P to each incoming ray, correcting the object mapping errors with the measured Power Delay Profile.</para>
        /// <para>Stage III: applies the directional reception characteristic gain G_kl = g / g_0 to the angular power distribution and sums the total power P_0 received by the directional antenna.</para>
        /// </summary>
        /// <param name="propagationModel">Input data of the multi-ellipsoidal propagation model.</param>
        /// <returns>Result of the comparative analysis or <see langword="null"/> for invalid input.</returns>
        public static PropagationResult? PropagationResult(this PropagationModel? propagationModel)
        {
            AntennaCharacteristic? receivingDirectionalCharacteristic = propagationModel?.ReceivingDirectionalCharacteristic;
            if (propagationModel == null || receivingDirectionalCharacteristic == null)
            {
                return null;
            }

            List<EllipsoidComponent>? ellipsoidComponents = propagationModel.EllipsoidComponents();
            if (ellipsoidComponents == null)
            {
                return null;
            }

            double totalPower = 0;
            foreach (EllipsoidComponent ellipsoidComponent in ellipsoidComponents)
            {
                totalPower += ellipsoidComponent.Power;
            }

            if (totalPower <= 0)
            {
                return null;
            }

            double directionalPower = 0;
            List<EllipsoidComponent> updatedEllipsoidComponents = [];
            List<ArrivalRay> arrivalRays = [];
            foreach (EllipsoidComponent ellipsoidComponent in ellipsoidComponents)
            {
                if (ellipsoidComponent.Power <= 0 || ellipsoidComponent.ReferencePower <= 0)
                {
                    updatedEllipsoidComponents.Add(ellipsoidComponent);
                    continue;
                }

                double fractionalPower = ellipsoidComponent.Power / totalPower;
                double mappingErrorCorrectionCoefficient = ellipsoidComponent.MeasuredFractionalPower / fractionalPower;
                double powerEquivalenceCoefficient = ellipsoidComponent.Power / ellipsoidComponent.ReferencePower;

                updatedEllipsoidComponents.Add(new EllipsoidComponent(
                    ellipsoidComponent.Delay,
                    fractionalPower,
                    mappingErrorCorrectionCoefficient,
                    ellipsoidComponent.MeasuredFractionalPower,
                    ellipsoidComponent.Power,
                    powerEquivalenceCoefficient,
                    ellipsoidComponent.RayContributions,
                    ellipsoidComponent.ReferencePower,
                    ellipsoidComponent.ReflectionCoefficientSum,
                    ellipsoidComponent.SemiMajorAxis,
                    ellipsoidComponent.SemiMinorAxis));

                List<RayContribution>? rayContributions = ellipsoidComponent.RayContributions;
                if (rayContributions == null)
                {
                    continue;
                }

                foreach (RayContribution rayContribution in rayContributions)
                {
                    double magnitude = rayContribution.ReflectionCoefficient.Magnitude;
                    double power = mappingErrorCorrectionCoefficient * powerEquivalenceCoefficient * rayContribution.TransmittingGain * rayContribution.ReceivingGain * magnitude * magnitude / totalPower;

                    arrivalRays.Add(new ArrivalRay(rayContribution.ThetaReceiver, rayContribution.PhiReceiver, power));

                    if (rayContribution.ReceivingGain > 0)
                    {
                        double gain = receivingDirectionalCharacteristic(rayContribution.ThetaReceiver, rayContribution.PhiReceiver) / rayContribution.ReceivingGain;
                        directionalPower += gain * power;
                    }
                }
            }

            return new PropagationResult(directionalPower, updatedEllipsoidComponents, arrivalRays, totalPower);
        }
    }
}