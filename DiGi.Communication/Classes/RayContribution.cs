using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Numerics;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Contribution of a single mesh cell (cell l of subset k) to an ellipsoid component: ray directions, antenna gains and reflection coefficients.
    /// </summary>
    public class RayContribution : SerializableObject, ICommunicationSerializableObject
    {
        /// <summary>
        /// Angle of incidence gamma_kl [rad] of the ray on the cell plane, measured from the plane (grazing angle).
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(IncidenceAngle))]
        private readonly double incidenceAngle;

        /// <summary>
        /// Azimuth angle phi_kl [rad] of the received ray, with origin at the receiver.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(PhiReceiver))]
        private readonly double phiReceiver;

        /// <summary>
        /// Azimuth angle phi_Tkl [rad] of the emitted ray, with origin at the transmitter.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(PhiTransmitter))]
        private readonly double phiTransmitter;

        /// <summary>
        /// Normalized reception characteristic value g_0kl of the omnidirectional receiving antenna for the received ray direction [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(ReceivingGain))]
        private readonly double receivingGain;

        /// <summary>
        /// Complex reflection coefficient Gamma_kl of the cell [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(ReflectionCoefficient))]
        private readonly Complex reflectionCoefficient;

        /// <summary>
        /// Polar angle theta_kl [rad] of the received ray, with origin at the receiver.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(ThetaReceiver))]
        private readonly double thetaReceiver;

        /// <summary>
        /// Polar angle theta_Tkl [rad] of the emitted ray, with origin at the transmitter.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(ThetaTransmitter))]
        private readonly double thetaTransmitter;

        /// <summary>
        /// Normalized radiation characteristic value g_T0kl of the omnidirectional transmitting antenna for the emitted ray direction [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(TransmittingGain))]
        private readonly double transmittingGain;

        /// <summary>
        /// Weighted complex reflection coefficient Gamma'_kl = g_T0kl * g_0kl * Gamma_kl [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(WeightedReflectionCoefficient))]
        private readonly Complex weightedReflectionCoefficient;

        /// <summary>
        /// Initializes a new instance of the <see cref="RayContribution"/> class.
        /// </summary>
        /// <param name="incidenceAngle">Angle of incidence gamma_kl [rad] of the ray on the cell plane, measured from the plane (grazing angle).</param>
        /// <param name="phiReceiver">Azimuth angle phi_kl [rad] of the received ray, with origin at the receiver.</param>
        /// <param name="phiTransmitter">Azimuth angle phi_Tkl [rad] of the emitted ray, with origin at the transmitter.</param>
        /// <param name="receivingGain">Normalized reception characteristic value g_0kl of the omnidirectional receiving antenna for the received ray direction [-].</param>
        /// <param name="reflectionCoefficient">Complex reflection coefficient Gamma_kl of the cell [-].</param>
        /// <param name="thetaReceiver">Polar angle theta_kl [rad] of the received ray, with origin at the receiver.</param>
        /// <param name="thetaTransmitter">Polar angle theta_Tkl [rad] of the emitted ray, with origin at the transmitter.</param>
        /// <param name="transmittingGain">Normalized radiation characteristic value g_T0kl of the omnidirectional transmitting antenna for the emitted ray direction [-].</param>
        /// <param name="weightedReflectionCoefficient">Weighted complex reflection coefficient Gamma'_kl = g_T0kl * g_0kl * Gamma_kl [-].</param>
        public RayContribution(double incidenceAngle, double phiReceiver, double phiTransmitter, double receivingGain, Complex reflectionCoefficient, double thetaReceiver, double thetaTransmitter, double transmittingGain, Complex weightedReflectionCoefficient)
        {
            this.incidenceAngle = incidenceAngle;
            this.phiReceiver = phiReceiver;
            this.phiTransmitter = phiTransmitter;
            this.receivingGain = receivingGain;
            this.reflectionCoefficient = reflectionCoefficient;
            this.thetaReceiver = thetaReceiver;
            this.thetaTransmitter = thetaTransmitter;
            this.transmittingGain = transmittingGain;
            this.weightedReflectionCoefficient = weightedReflectionCoefficient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RayContribution"/> class by copying another ray contribution.
        /// </summary>
        /// <param name="rayContribution">The source ray contribution to copy from.</param>
        public RayContribution(RayContribution? rayContribution)
            : base(rayContribution)
        {
            if (rayContribution != null)
            {
                incidenceAngle = rayContribution.incidenceAngle;
                phiReceiver = rayContribution.phiReceiver;
                phiTransmitter = rayContribution.phiTransmitter;
                receivingGain = rayContribution.receivingGain;
                reflectionCoefficient = rayContribution.reflectionCoefficient;
                thetaReceiver = rayContribution.thetaReceiver;
                thetaTransmitter = rayContribution.thetaTransmitter;
                transmittingGain = rayContribution.transmittingGain;
                weightedReflectionCoefficient = rayContribution.weightedReflectionCoefficient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RayContribution"/> class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data.</param>
        public RayContribution(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Angle of incidence gamma_kl [rad] of the ray on the cell plane, measured from the plane (grazing angle).
        /// </summary>
        [JsonIgnore]
        public double IncidenceAngle
        {
            get
            {
                return incidenceAngle;
            }
        }

        /// <summary>
        /// Azimuth angle phi_kl [rad] of the received ray, with origin at the receiver.
        /// </summary>
        [JsonIgnore]
        public double PhiReceiver
        {
            get
            {
                return phiReceiver;
            }
        }

        /// <summary>
        /// Azimuth angle phi_Tkl [rad] of the emitted ray, with origin at the transmitter.
        /// </summary>
        [JsonIgnore]
        public double PhiTransmitter
        {
            get
            {
                return phiTransmitter;
            }
        }

        /// <summary>
        /// Normalized reception characteristic value g_0kl of the omnidirectional receiving antenna for the received ray direction [-].
        /// </summary>
        [JsonIgnore]
        public double ReceivingGain
        {
            get
            {
                return receivingGain;
            }
        }

        /// <summary>
        /// Complex reflection coefficient Gamma_kl of the cell [-].
        /// </summary>
        [JsonIgnore]
        public Complex ReflectionCoefficient
        {
            get
            {
                return reflectionCoefficient;
            }
        }

        /// <summary>
        /// Polar angle theta_kl [rad] of the received ray, with origin at the receiver.
        /// </summary>
        [JsonIgnore]
        public double ThetaReceiver
        {
            get
            {
                return thetaReceiver;
            }
        }

        /// <summary>
        /// Polar angle theta_Tkl [rad] of the emitted ray, with origin at the transmitter.
        /// </summary>
        [JsonIgnore]
        public double ThetaTransmitter
        {
            get
            {
                return thetaTransmitter;
            }
        }

        /// <summary>
        /// Normalized radiation characteristic value g_T0kl of the omnidirectional transmitting antenna for the emitted ray direction [-].
        /// </summary>
        [JsonIgnore]
        public double TransmittingGain
        {
            get
            {
                return transmittingGain;
            }
        }

        /// <summary>
        /// Weighted complex reflection coefficient Gamma'_kl = g_T0kl * g_0kl * Gamma_kl [-].
        /// </summary>
        [JsonIgnore]
        public Complex WeightedReflectionCoefficient
        {
            get
            {
                return weightedReflectionCoefficient;
            }
        }
    }
}