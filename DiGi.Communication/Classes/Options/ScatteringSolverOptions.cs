using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Provides configuration options and parameters for the scattering solver,
    /// including factors for angle calculation and point density.
    /// </summary>
    public class ScatteringSolverOptions : SerializableObject, ICommunicationSerializableObject, IOptions
    {
        [JsonInclude, JsonPropertyName(nameof(AngleFactor))]
        private readonly double angleFactor = Constants.Factor.Angle;

        [JsonInclude, JsonPropertyName(nameof(PointDensityFactor))]
        private readonly double pointDensityFactor = Constants.Factor.PointDensity;

        [JsonInclude, JsonPropertyName(nameof(Tolerance))]
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringSolverOptions"/> class.
        /// </summary>
        public ScatteringSolverOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringSolverOptions"/> class.
        /// </summary>
        /// <param name="angleFactor">The angle factor used by the scattering solver for angular calculations.</param>
        /// <param name="pointDensityFactor">The factor used to determine the point density for the scattering solver.</param>
        /// <param name="tolerance">The tolerance value used for distance and geometric comparisons.</param>
        public ScatteringSolverOptions(double angleFactor, double pointDensityFactor, double tolerance)
            : base()
        {
            this.angleFactor = angleFactor;
            this.pointDensityFactor = pointDensityFactor;
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringSolverOptions"/> class by copying from another instance.
        /// </summary>
        /// <param name="other">The source options to copy from.</param>
        public ScatteringSolverOptions(ScatteringSolverOptions? other)
            : base(other)
        {
            if (other != null)
            {
                angleFactor = other.angleFactor;
                pointDensityFactor = other.pointDensityFactor;
                tolerance = other.tolerance;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringSolverOptions"/> class from JSON.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to deserialize.</param>
        public ScatteringSolverOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the angle factor used by the scattering solver for angular calculations.
        /// </summary>
        [JsonIgnore]
        public double AngleFactor
        {
            get
            {
                return angleFactor;
            }
        }

        /// <summary>
        /// Gets the factor used to determine the point density for the scattering solver.
        /// </summary>
        [JsonIgnore]
        public double PointDensityFactor
        {
            get
            {
                return pointDensityFactor;
            }
        }

        /// <summary>
        /// Gets the tolerance value used for distance and geometric comparisons within the scattering solver.
        /// </summary>
        [JsonIgnore]
        public double Tolerance
        {
            get
            {
                return tolerance;
            }
        }
    }
}