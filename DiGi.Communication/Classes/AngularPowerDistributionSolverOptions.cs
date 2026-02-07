using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class AngularPowerDistributionSolverOptions : SerializableObject, ICommunicationObject, IOptions
    {
        [JsonInclude, JsonPropertyName("Tolerance")]
        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;

        [JsonInclude, JsonPropertyName("RayCount")]
        public int RayCount { get; set; } = 1;
    }
}