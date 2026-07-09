using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Ray arriving at the receiving antenna: an arrival direction (theta, phi) with its assigned corrected power p_nkl.
    /// </summary>
    public class ArrivalRay : SerializableObject, ICommunicationSerializableObject
    {
        /// <summary>
        /// Azimuth angle phi_kl [rad] of the arrival direction, measured in the XOY plane from the OX axis at the receiver.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Phi))]
        private readonly double phi;

        /// <summary>
        /// Corrected normalized power p_nkl assigned to the ray [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Power))]
        private readonly double power;

        /// <summary>
        /// Polar angle theta_kl [rad] of the arrival direction, measured from the OZ axis at the receiver.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Theta))]
        private readonly double theta;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrivalRay"/> class.
        /// </summary>
        /// <param name="theta">Polar angle theta_kl [rad] of the arrival direction, measured from the OZ axis at the receiver.</param>
        /// <param name="phi">Azimuth angle phi_kl [rad] of the arrival direction, measured in the XOY plane from the OX axis at the receiver.</param>
        /// <param name="power">Corrected normalized power p_nkl assigned to the ray [-].</param>
        public ArrivalRay(double theta, double phi, double power)
        {
            this.theta = theta;
            this.phi = phi;
            this.power = power;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrivalRay"/> class by copying another ray.
        /// </summary>
        /// <param name="arrivalRay">The source ray to copy from.</param>
        public ArrivalRay(ArrivalRay? arrivalRay)
            : base(arrivalRay)
        {
            if (arrivalRay != null)
            {
                theta = arrivalRay.theta;
                phi = arrivalRay.phi;
                power = arrivalRay.power;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrivalRay"/> class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data.</param>
        public ArrivalRay(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Azimuth angle phi_kl [rad] of the arrival direction, measured in the XOY plane from the OX axis at the receiver.
        /// </summary>
        [JsonIgnore]
        public double Phi
        {
            get
            {
                return phi;
            }
        }

        /// <summary>
        /// Corrected normalized power p_nkl assigned to the ray [-].
        /// </summary>
        [JsonIgnore]
        public double Power
        {
            get
            {
                return power;
            }
        }

        /// <summary>
        /// Polar angle theta_kl [rad] of the arrival direction, measured from the OZ axis at the receiver.
        /// </summary>
        [JsonIgnore]
        public double Theta
        {
            get
            {
                return theta;
            }
        }
    }
}
