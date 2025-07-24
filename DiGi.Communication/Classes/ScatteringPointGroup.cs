using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class ScatteringPointGroup : SerializableObject, ICommunicationSerializableObject
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private string reference;

        [JsonInclude, JsonPropertyName("Points")]
        private List<Point3D> points;
        public ScatteringPointGroup(string reference, IEnumerable<Point3D> points)
            : base()
        {
            this.points = Core.Query.Clone(points);
            this.reference = reference;
        }

        public ScatteringPointGroup(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ScatteringPointGroup(ScatteringPointGroup scatteringPointGroup)
            : base(scatteringPointGroup)
        {
            if (scatteringPointGroup != null)
            {
                points = Core.Query.Clone(scatteringPointGroup.points);
                reference = scatteringPointGroup.Reference;
            }
        }

        [JsonIgnore]
        public string Reference
        {
            get
            {
                return reference;
            }
        }

        [JsonIgnore]
        public List<Point3D> Points
        {
            get
            {
                return Core.Query.Clone(points);
            }
        }
    }
}
