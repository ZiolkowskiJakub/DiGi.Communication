using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Communication.ComputeSharp.Classes
{
    public class ScatteringCalculatorOptions : SerializableObject, ICommunicationObject, IOptions
    {
        [JsonInclude, JsonPropertyName("AngleFactor")]
        public double AngleFactor { get; set; } = Constans.Factor.Angle;

        [JsonInclude, JsonPropertyName("PointDensityFactor")]
        public double PointDensityFactor { get; set; } = Constans.Factor.PointDensity;

        [JsonInclude, JsonPropertyName("Tolerance")]
        public double Tolerance { get; set; } = Core.Constans.Tolerance.Distance;
    }
}
