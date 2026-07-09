using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Single point of the normalized Power Delay Profile (PDP): a delay tau_n and the normalized (fractional) power arriving with that delay.
    /// </summary>
    public class PowerDelayProfilePoint : SerializableObject, ICommunicationSerializableObject
    {
        /// <summary>
        /// Delay tau_n [s].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Delay))]
        private readonly double delay;

        /// <summary>
        /// Normalized (fractional) power p'_n arriving with the given delay [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(FractionalPower))]
        private readonly double fractionalPower;

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerDelayProfilePoint"/> class.
        /// </summary>
        /// <param name="delay">Delay tau_n [s].</param>
        /// <param name="fractionalPower">Normalized (fractional) power p'_n arriving with the given delay [-].</param>
        public PowerDelayProfilePoint(double delay, double fractionalPower)
        {
            this.delay = delay;
            this.fractionalPower = fractionalPower;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerDelayProfilePoint"/> class by copying another power delay profile point.
        /// </summary>
        /// <param name="powerDelayProfilePoint">The source power delay profile point to copy from.</param>
        public PowerDelayProfilePoint(PowerDelayProfilePoint? powerDelayProfilePoint)
            : base(powerDelayProfilePoint)
        {
            if (powerDelayProfilePoint != null)
            {
                delay = powerDelayProfilePoint.delay;
                fractionalPower = powerDelayProfilePoint.fractionalPower;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerDelayProfilePoint"/> class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data.</param>
        public PowerDelayProfilePoint(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Delay tau_n [s].
        /// </summary>
        [JsonIgnore]
        public double Delay
        {
            get
            {
                return delay;
            }
        }

        /// <summary>
        /// Normalized (fractional) power p'_n arriving with the given delay [-].
        /// </summary>
        [JsonIgnore]
        public double FractionalPower
        {
            get
            {
                return fractionalPower;
            }
        }
    }
}
