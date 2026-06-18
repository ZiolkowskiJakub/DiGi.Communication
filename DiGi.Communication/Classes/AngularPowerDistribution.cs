using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents the angular power distribution, encapsulating the time delay and the associated spatial vectors.
    /// </summary>
    public class AngularPowerDistribution : SerializableObject, IAngularPowerDistribution
    {
        [JsonInclude, JsonPropertyName("Delay")]
        private readonly double delay;

        [JsonInclude, JsonPropertyName("Vectors")]
        private readonly List<Vector3D>? vectors;

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistribution"/> class.
        /// </summary>
        /// <param name="delay">The delay value for the power distribution.</param>
        /// <param name="vectors">A collection of three-dimensional vectors defining the angular power distribution.</param>
        public AngularPowerDistribution(double delay, IEnumerable<Vector3D>? vectors)
            : base()
        {
            this.delay = delay;
            this.vectors = Core.Query.CloneAndFilterNulls(vectors);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistribution"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the current instance.</param>
        public AngularPowerDistribution(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistribution"/> class by copying values from an existing instance.
        /// </summary>
        /// <param name="angularPowerDistribution">The source <see cref="AngularPowerDistribution"/> instance to copy data from, or <see langword="null"/>.</param>
        public AngularPowerDistribution(AngularPowerDistribution? angularPowerDistribution)
            : base(angularPowerDistribution)
        {
            if (angularPowerDistribution != null)
            {
                delay = angularPowerDistribution.delay;
                vectors = Core.Query.CloneAndFilterNulls(angularPowerDistribution.vectors);
            }
        }

        /// <summary> Gets the delay associated with the angular power distribution. </summary>
        [JsonIgnore]
        public double Delay
        {
            get
            {
                return delay;
            }
        }

        /// <summary> Gets the collection of three-dimensional vectors associated with the angular power distribution, filtered to remove null entries. </summary>
        [JsonIgnore]
        public List<Vector3D>? Vectors
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(vectors);
            }
        }

        /// <summary>
        /// Calculates the total power by summing the lengths of all stored vectors.
        /// </summary>
        /// <returns>The sum of the vector lengths, or <see cref="double.NaN"/> if the vectors collection is null.</returns>
        public double GetPower()
        {
            if (vectors == null)
            {
                return double.NaN;
            }

            return vectors.ConvertAll(x => x.Length).Sum();
        }
    }
}
