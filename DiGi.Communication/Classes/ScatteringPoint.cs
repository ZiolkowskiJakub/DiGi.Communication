using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class ScatteringPoint : SerializableObject, ICommunicationObject
    {
        [JsonInclude, JsonPropertyName("Point")]
        private Point3D point;

        public ScatteringPoint(Point3D point)
            : base()
        {
            this.point = Core.Query.Clone(point);
        }

        public ScatteringPoint(JsonObject jsonObject)
            :base(jsonObject)
        {
            
        }

        public ScatteringPoint(ScatteringPoint scatteringPoint)
            : base(scatteringPoint)
        {
            if(scatteringPoint != null)
            {
                point = Core.Query.Clone(scatteringPoint.point);
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
    }
}
