using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class ScatteringObject : GuidObject, IScatteringObject
    {
        [JsonInclude, JsonPropertyName("Mesh3D")]
        private Mesh3D mesh3D;

        [JsonInclude, JsonPropertyName("Reference")]
        private string reference;

        [JsonInclude, JsonPropertyName("ScatteringCoefficient")]
        private double scatteringCoefficient = 1.0;

        public ScatteringObject(Guid guid, string reference, Mesh3D mesh3D, double scatteringCoefficient = 1.0)
            : base(guid)
        {
            this.reference = string.IsNullOrWhiteSpace(reference) ? guid.ToString() : reference;
            this.mesh3D = Core.Query.Clone(mesh3D);
            this.scatteringCoefficient = scatteringCoefficient;
        }

        public ScatteringObject(string reference, Mesh3D mesh3D, double scatteringCoefficient = 1.0)
            : base()
        {
            this.reference = string.IsNullOrWhiteSpace(reference) ? Guid.ToString() : reference;
            this.mesh3D = Core.Query.Clone(mesh3D);
            this.scatteringCoefficient = scatteringCoefficient;
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
                scatteringCoefficient = scatteringObject.scatteringCoefficient;
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

        [JsonIgnore]
        public double ScatteringCoefficient
        {
            get
            {
                return scatteringCoefficient;
            }
        }
    }
}
