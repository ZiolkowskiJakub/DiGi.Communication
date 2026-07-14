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
        /// Gets or sets the tolerance value used for comparisons and geometric operations within the angular power distribution solver.
        /// </summary>
        [JsonInclude, JsonPropertyName("Tolerance")]
        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;

        /// <summary>
        /// Gets or sets the number of rays used by the angular power distribution solver.
        /// </summary>
        [JsonInclude, JsonPropertyName("RayCount")]
        public int RayCount { get; set; } = 1;
    }
}