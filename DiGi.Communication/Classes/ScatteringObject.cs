using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class ScatteringObject : SerializableObject, IScatteringObject
    {
        [JsonInclude, JsonPropertyName("Mesh3D")]
        private Mesh3D mesh3D;

        [JsonInclude, JsonPropertyName("Reference")]
        private string reference;
        
        public ScatteringObject(string reference, Mesh3D mesh3D)
            : base()
        {
            this.reference = reference;
            this.mesh3D = Core.Query.Clone(mesh3D);

        }

        public ScatteringObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ScatteringObject(ScatteringObject scatteringObject)
            : base(scatteringObject)
        {
            if (scatteringObject != null)
            {
                reference = scatteringObject.reference;
                mesh3D = Core.Query.Clone(scatteringObject.mesh3D);
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
        public Mesh3D Mesh3D
        {
            get
            {
                return Core.Query.Clone(mesh3D);
            }
        }
    }
}
