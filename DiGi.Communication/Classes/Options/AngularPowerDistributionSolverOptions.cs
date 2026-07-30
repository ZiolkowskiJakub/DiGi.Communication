using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Provides configuration options for the angular power distribution solver, including tolerance and ray count settings.
    /// </summary>
    public class AngularPowerDistributionSolverOptions : SerializableObject, ICommunicationObject, IOptions
    {
        /// <summary>
        /// Frequency [Hz].
        /// </summary>
        [JsonInclude, JsonPropertyName("Frequency")]
        public double Frequency { get; set; } = 5e9;
    }
}