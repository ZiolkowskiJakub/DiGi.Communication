using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class Antenna : GuidObject, IAntenna
    {
        [JsonInclude, JsonPropertyName("Functions")]
        private HashSet<Function> functions;

        [JsonInclude, JsonPropertyName("Location")]
        private Point3D location;
        
        public Antenna(Guid guid, Point3D location, params Function[] functions)
            : base(guid)
        {
            this.location = Core.Query.Clone(location);
            this.functions = functions == null ? null : [.. functions];
        }

        public Antenna(Point3D location, params Function[] functions)
            : base()
        {
            this.location = Core.Query.Clone(location);
            this.functions = functions == null ? null : [.. functions];
        }

        public Antenna(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Antenna(Antenna antenna)
            : base(antenna)
        {
            if (antenna != null)
            {
                location = Core.Query.Clone(antenna.location);
                functions = antenna.functions == null ? null : [.. antenna.functions];
            }
        }

        [JsonIgnore]
        public HashSet<Function> Functions
        {
            get
            {
                return functions == null ? null : [.. functions];
            }
        }

        [JsonIgnore]
        public Point3D Location
        {
            get
            {
                return Core.Query.Clone(location);
            }
        }
    }
}
