using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class AngularPowerDistributionProfile : GuidObject, IAngularPowerDistributionProfile
    {
        [JsonIgnore]
        private SortedDictionary<double, AngularPowerDistribution> dictionary;

        [JsonInclude, JsonPropertyName("Point")]
        private Point3D point;

        public AngularPowerDistributionProfile(Guid guid, Point3D point, IEnumerable<AngularPowerDistribution> angularPowerDistributions)
            : base(guid)
        {
            this.point = Core.Query.Clone(point);
            AngularPowerDistributions = angularPowerDistributions;
        }

        public AngularPowerDistributionProfile(Point3D point, IEnumerable<AngularPowerDistribution> angularPowerDistributions)
            : base()
        {
            this.point = Core.Query.Clone(point);
            AngularPowerDistributions = angularPowerDistributions;
        }

        public AngularPowerDistributionProfile(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public AngularPowerDistributionProfile(AngularPowerDistributionProfile angularPowerDistributionProfile)
            : base(angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile != null)
            {
                point = angularPowerDistributionProfile.Point;
                AngularPowerDistributions = angularPowerDistributionProfile.dictionary?.Values;
            }
        }

        [JsonInclude, JsonPropertyName("AngularPowerDistributions")]
        public IEnumerable<AngularPowerDistribution> AngularPowerDistributions
        {
            get
            {
                if (dictionary == null)
                {
                    return null;
                }

                List<AngularPowerDistribution> result = new List<AngularPowerDistribution>();
                foreach (AngularPowerDistribution angularPowerDistribution in dictionary.Values)
                {
                    result.Add(Core.Query.Clone(angularPowerDistribution));
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

                dictionary.Clear();
                foreach (AngularPowerDistribution angularPowerDistribution in value)
                {
                    if (angularPowerDistribution == null)
                    {
                        continue;
                    }

                    dictionary[angularPowerDistribution.Delay] = Core.Query.Clone(angularPowerDistribution);
                }
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
