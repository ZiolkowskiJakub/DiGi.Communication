using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class Scattering : SerializableObject, IScattering
    {
        [JsonInclude, JsonPropertyName("Delay")]
        private double delay;

        [JsonInclude, JsonPropertyName("ScatteringPointGroups")]
        private List<ScatteringPointGroup> scatteringPointGroups;

        public Scattering(double delay)
        {
            this.delay = delay;
            scatteringPointGroups = new List<ScatteringPointGroup>();
        }

        public Scattering(double delay, IEnumerable<ScatteringPointGroup> scatteringPointGroups)
            : base()
        {
            this.delay = delay;
            this.scatteringPointGroups = Core.Query.Clone(scatteringPointGroups);
        }

        public Scattering(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Scattering(Scattering scattering)
            : base(scattering)
        {
            if (scattering != null)
            {
                delay = scattering.delay;
                scatteringPointGroups = Core.Query.Clone(scattering.scatteringPointGroups);
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
        public List<ScatteringPointGroup> ScatteringPointGroups
        {
            get
            {
                return Core.Query.Clone(scatteringPointGroups);
            }
        }
    }
}
