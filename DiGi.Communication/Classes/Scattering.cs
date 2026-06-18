using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents the scattering properties within a communication system,
    /// containing information about signal delay and associated scattering point groups.
    /// </summary>
    public class Scattering : SerializableObject, IScattering
    {
        [JsonInclude, JsonPropertyName("Delay")]
        private readonly double delay;

        [JsonInclude, JsonPropertyName("ScatteringPointGroups")]
        private readonly List<ScatteringPointGroup>? scatteringPointGroups;

        /// <summary>
        /// Initializes a new instance of the <see cref="Scattering"/> class with the specified delay.
        /// </summary>
        /// <param name="delay">The delay value to be assigned to this scattering instance.</param>
        public Scattering(double delay)
        {
            this.delay = delay;
            scatteringPointGroups = [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scattering"/> class.
        /// </summary>
        /// <param name="delay">The delay value for the scattering.</param>
        /// <param name="scatteringPointGroups">A collection of scattering point groups to be associated with this scattering instance.</param>
        public Scattering(double delay, IEnumerable<ScatteringPointGroup>? scatteringPointGroups)
            : base()
        {
            this.delay = delay;
            this.scatteringPointGroups = Core.Query.CloneAndFilterNulls(scatteringPointGroups);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scattering"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the current instance.</param>
        public Scattering(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scattering"/> class by copying values from an existing <see cref="Scattering"/> instance.
        /// </summary>
        /// <param name="scattering">The source <see cref="Scattering"/> object to copy data from, or <see langword="null"/> to initialize a default instance.</param>
        public Scattering(Scattering? scattering)
            : base(scattering)
        {
            if (scattering != null)
            {
                delay = scattering.delay;
                scatteringPointGroups = Core.Query.CloneAndFilterNulls(scattering.scatteringPointGroups);
            }
        }

        /// <summary> Gets the delay associated with the scattering process. </summary>
        [JsonIgnore]
        public double Delay
        {
            get
            {
                return delay;
            }
        }

        /// <summary> Gets the collection of scattering point groups, filtered to remove null entries and cloned for safety. </summary>
        [JsonIgnore]
        public List<ScatteringPointGroup>? ScatteringPointGroups
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(scatteringPointGroups);
            }
        }
    }
}
