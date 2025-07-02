using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class ScatteringPointGroup : SerializableObject, ICommunicationObject
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private string reference;

        [JsonInclude, JsonPropertyName("ScatteringPoints")]
        private List<ScatteringPoint> scatteringPoints;
        public ScatteringPointGroup(string reference, IEnumerable<ScatteringPoint> scatteringPoints)
            : base()
        {
            this.scatteringPoints = Core.Query.Clone(scatteringPoints);
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
                scatteringPoints = Core.Query.Clone(scatteringPointGroup.scatteringPoints);
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
        public List<ScatteringPoint> ScatteringPoints
        {
            get
            {
                return Core.Query.Clone(scatteringPoints);
            }
        }

        public List<Point3D> GetPoints()
        {
            return scatteringPoints?.ConvertAll(x => x.Point);
        }
    }
}
