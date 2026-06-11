using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Communication.ComputeSharp.Classes
{
    /// <summary>
    /// Provides configuration options and parameters for the scattering solver,
    /// including factors for angle calculation and point density.
    /// </summary>
    public class ScatteringSolverOptions : SerializableObject, ICommunicationObject, IOptions
    {
        /// <summary>
        /// Gets or sets the angle factor used by the scattering solver for angular calculations.
        /// </summary>
        [JsonInclude, JsonPropertyName("AngleFactor")]
        public double AngleFactor { get; set; } = Constants.Factor.Angle;

        /// <summary>
        /// Gets or sets the factor used to determine the point density for the scattering solver.
        /// </summary>
        [JsonInclude, JsonPropertyName("PointDensityFactor")]
        public double PointDensityFactor { get; set; } = Constants.Factor.PointDensity;

        /// <summary>
        /// Gets or sets the tolerance value used for distance and geometric comparisons within the scattering solver.
        /// </summary>
        [JsonInclude, JsonPropertyName("Tolerance")]
        public double Tolerance { get; set; } = Core.Constants.Tolerance.Distance;
    }
}