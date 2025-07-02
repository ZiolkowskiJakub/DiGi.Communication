using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class Scattering : SerializableObject, ICommunicationObject
    {
        [JsonInclude, JsonPropertyName("Location_1")]
        private Point3D location_1;

        [JsonInclude, JsonPropertyName("Location_2")]
        private Point3D location_2;

        [JsonInclude, JsonPropertyName("ScatteringPoints")]
        private List<ScatteringPointGroup> scatteringPointGroups;
        
        public Scattering(Point3D location_1, Point3D location_2, IEnumerable<ScatteringPointGroup> scatteringPointGroups)
            : base()
        {
            this.scatteringPointGroups = Core.Query.Clone(scatteringPointGroups);
            this.location_1 = Core.Query.Clone(location_1);
            this.location_2 = Core.Query.Clone(location_2);
        }

        public Scattering(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Scattering(Scattering scatteringPointGroup)
            : base(scatteringPointGroup)
        {
            if (scatteringPointGroup != null)
            {
                scatteringPointGroups = Core.Query.Clone(scatteringPointGroup.scatteringPointGroups);
                location_1 = Core.Query.Clone(scatteringPointGroup.location_1);
                location_2 = Core.Query.Clone(scatteringPointGroup.location_2);
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

        [JsonIgnore]
        public List<ScatteringPointGroup> ScatteringPointGroups
        {
            get
            {
                return Core.Query.Clone(scatteringPointGroups);
            }
        }

        public List<Polyline3D> GetPolylines()
        {
            if(scatteringPointGroups == null || location_1 == null || location_2 == null)
            {
                return null;
            }

            List<Polyline3D> result = new List<Polyline3D>();
            foreach(ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
            {
                List<Point3D> point3Ds = scatteringPointGroup?.GetPoints();
                if(point3Ds == null)
                {
                    continue;
                }

                foreach(Point3D point3D in point3Ds)
                {
                    if(point3D == null)
                    {
                        continue;
                    }

                    Polyline3D polyline3D = new Polyline3D([location_1, point3D, location_2]);
                    result.Add(polyline3D);
                }
            }

            return result;
        }
    }
}
