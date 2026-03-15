using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Communication.ComputeSharp.Classes
{
    public class ScatteringSolverOptions : SerializableObject, ICommunicationObject, IOptions
    {
        [JsonInclude, JsonPropertyName("AngleFactor")]
        public double AngleFactor { get; set; } = Constants.Factor.Angle;

        [JsonInclude, JsonPropertyName("PointDensityFactor")]
        public double PointDensityFactor { get; set; } = Constants.Factor.PointDensity;

        [JsonInclude, JsonPropertyName("Tolerance")]
        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;
    }
}