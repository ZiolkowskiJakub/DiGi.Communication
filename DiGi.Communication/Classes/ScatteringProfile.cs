using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class ScatteringProfile : GuidObject, IScatteringProfile
    {
        [JsonInclude, JsonPropertyName("Location_1")]
        private Point3D location_1;

        [JsonInclude, JsonPropertyName("Location_2")]
        private Point3D location_2;

        [JsonIgnore]
        private SortedDictionary<double, Scattering> dictionary;

        [JsonInclude, JsonPropertyName("Visible")]
        private bool visible;

        public ScatteringProfile(Guid guid, Point3D location_1, Point3D location_2, bool visible, IEnumerable<Scattering> scatterings)
            : base(guid)
        {
            this.visible = visible;
            this.location_1 = Core.Query.Clone(location_1);
            this.location_2 = Core.Query.Clone(location_2);
            Scatterings = scatterings;
        }

        public ScatteringProfile(bool visible, Point3D location_1, Point3D location_2, IEnumerable<Scattering> scatterings)
            : base()
        {
            this.visible = visible;
            this.location_1 = Core.Query.Clone(location_1);
            this.location_2 = Core.Query.Clone(location_2);
            Scatterings = scatterings;
        }

        public ScatteringProfile(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ScatteringProfile(ScatteringProfile scatteringProfile)
            : base(scatteringProfile)
        {
            if (scatteringProfile != null)
            {
                visible = scatteringProfile.visible;
                location_1 = Core.Query.Clone(scatteringProfile.location_1);
                location_2 = Core.Query.Clone(scatteringProfile.location_2);
                Scatterings = scatteringProfile.dictionary?.Values;
            }
        }

        [JsonInclude, JsonPropertyName("Scatterings")]
        public IEnumerable<Scattering> Scatterings
        {
            get
            {
                if (dictionary == null)
                {
                    return null;
                }

                List<Scattering> result = new List<Scattering>();
                foreach (Scattering scattering in dictionary.Values)
                {
                    result.Add(Core.Query.Clone(scattering));
                }
                return result;
            }

            private set
            {
                if (value == null)
                {
                    dictionary = null;
                    return;
                }

                if(dictionary == null)
                {
                    dictionary = new SortedDictionary<double, Scattering>();
                }
                else
                {
                    dictionary.Clear();
                }

                foreach (Scattering scattering in value)
                {
                    if (scattering == null)
                    {
                        continue;
                    }

                    dictionary[scattering.Delay] = Core.Query.Clone(scattering);
                }
            }
        }

        [JsonIgnore]
        public bool Visible
        {
            get
            {
                return visible;
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
    }
}
