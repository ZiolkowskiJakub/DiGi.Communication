using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class AngularPowerDistribution : SerializableObject, IAngularPowerDistribution
    {
        [JsonInclude, JsonPropertyName("Delay")]
        private readonly double delay;

        [JsonInclude, JsonPropertyName("Vectors")]
        private readonly List<Vector3D>? vectors;

        public AngularPowerDistribution(double delay, IEnumerable<Vector3D>? vectors)
            : base()
        {
            this.delay = delay;
            this.vectors = Core.Query.CloneAndFilterNulls(vectors);
        }

        public AngularPowerDistribution(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public AngularPowerDistribution(AngularPowerDistribution? angularPowerDistribution)
            : base(angularPowerDistribution)
        {
            if (angularPowerDistribution != null)
            {
                delay = angularPowerDistribution.delay;
                vectors = Core.Query.CloneAndFilterNulls(angularPowerDistribution.vectors);
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
        public List<Vector3D>? Vectors
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(vectors);
            }
        }

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
