using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class EllipsoidalPropagation : SerializableObject, ICommunicationObject
    {
        [JsonInclude, JsonPropertyName("B")]
        private double b;

        [JsonInclude, JsonPropertyName("Location_1")]
        private Point3D location_1;

        [JsonInclude, JsonPropertyName("Location_2")]
        private Point3D location_2;
        public EllipsoidalPropagation(Point3D location_1, Point3D location_2, double b)
            : base()
        {
            this.location_1 = Core.Query.Clone(location_1);
            this.location_2 = Core.Query.Clone(location_2);
            this.b = b;
        }

        public EllipsoidalPropagation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public EllipsoidalPropagation(EllipsoidalPropagation ellipsoidalPropagation)
            : base(ellipsoidalPropagation)
        {
            if (ellipsoidalPropagation != null)
            {
                location_1 = Core.Query.Clone(ellipsoidalPropagation.location_1);
                location_2 = Core.Query.Clone(ellipsoidalPropagation.location_2);
                b = ellipsoidalPropagation.b;
            }
        }

        [JsonIgnore]
        public double B
        {
            get
            {
                return b;
            }
        }

        [JsonIgnore]
        public Point3D Location_1
        {
            get
            {
                return Core.Query.Clone(location_1);
            }
        }

        [JsonIgnore]
        public Point3D Location_2
        {
            get
            {
                return Core.Query.Clone(location_2);
            }
        }

        public Ellipsoid GetEllipsoid(double tolerance = Core.Constans.Tolerance.Distance)
        {
            return Geometry.Spatial.Create.Ellipsoid(location_1, location_2, b, b);
        }
    }
}
