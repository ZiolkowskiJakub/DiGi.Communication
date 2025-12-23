using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class Scattering : SerializableObject, IScattering
    {
        [JsonInclude, JsonPropertyName("Delay")]
        private readonly double delay;

        [JsonInclude, JsonPropertyName("ScatteringPointGroups")]
        private readonly List<ScatteringPointGroup>? scatteringPointGroups;

        public Scattering(double delay)
        {
            this.delay = delay;
            scatteringPointGroups = [];
        }

        public Scattering(double delay, IEnumerable<ScatteringPointGroup>? scatteringPointGroups)
            : base()
        {
            this.delay = delay;
            this.scatteringPointGroups = Core.Query.CloneAndFilterNulls(scatteringPointGroups);
        }

        public Scattering(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public Scattering(Scattering? scattering)
            : base(scattering)
        {
            if (scattering != null)
            {
                delay = scattering.delay;
                scatteringPointGroups = Core.Query.CloneAndFilterNulls(scattering.scatteringPointGroups);
            }
        }

        [JsonIgnore]
        public double Delay
        {
            get
            {
                return delay;
            }
        }

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
