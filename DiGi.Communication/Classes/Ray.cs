using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class Ray : SerializableObject, ICommunicationSerializableObject
    {
        [JsonInclude, JsonPropertyName("Point")]
        private Point3D point;

        [JsonInclude, JsonPropertyName("Vector")]
        private Vector3D vector;

        public Ray(Point3D point, Vector3D vector)
            : base()
        {
            this.point = Core.Query.Clone(point);
            this.vector = Core.Query.Clone(vector);
        }

        public Ray(JsonObject jsonObject)
            :base(jsonObject)
        {
            
        }

        public Ray(Ray ray)
            : base(ray)
        {
            if(ray != null)
            {
                point = Core.Query.Clone(ray.point);
                vector = Core.Query.Clone(ray.vector);
            }
        }

        [JsonIgnore]
        public Point3D Point
        {
            get
            {
                return Core.Query.Clone(point);
            }
        }

        [JsonIgnore]
        public Vector3D Vector
        {
            get
            {
                return Core.Query.Clone(vector);
            }
        }
    }
}
