using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class AngularPowerDistributionProfile : GuidObject, IAngularPowerDistributionProfile
    {
        [JsonIgnore]
        private SortedDictionary<double, AngularPowerDistribution>? dictionary;

        [JsonInclude, JsonPropertyName("Location")]
        private readonly Point3D? location;

        public AngularPowerDistributionProfile(Guid guid, Point3D? location, IEnumerable<AngularPowerDistribution>? angularPowerDistributions)
            : base(guid)
        {
            this.location = Core.Query.Clone(location);
            AngularPowerDistributions = angularPowerDistributions;
        }

        public AngularPowerDistributionProfile(Point3D? location, IEnumerable<AngularPowerDistribution>? angularPowerDistributions)
            : base()
        {
            this.location = Core.Query.Clone(location);
            AngularPowerDistributions = angularPowerDistributions;
        }

        public AngularPowerDistributionProfile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public AngularPowerDistributionProfile(AngularPowerDistributionProfile? angularPowerDistributionProfile)
            : base(angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile != null)
            {
                location = angularPowerDistributionProfile.Location;
                AngularPowerDistributions = angularPowerDistributionProfile.dictionary?.Values;
            }
        }

        [JsonInclude, JsonPropertyName("AngularPowerDistributions")]
        public IEnumerable<AngularPowerDistribution>? AngularPowerDistributions
        {
            get
            {
                if (dictionary == null)
                {
                    return null;
                }

                List<AngularPowerDistribution> result = [];
                foreach (AngularPowerDistribution angularPowerDistribution in dictionary.Values)
                {
                    if (Core.Query.Clone(angularPowerDistribution) is AngularPowerDistribution angularPowerDistribution_Temp)
                    {
                        result.Add(angularPowerDistribution_Temp);
                    }
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

                if (dictionary == null)
                {
                    dictionary = [];
                }
                else
                {
                    dictionary.Clear();
                }

                foreach (AngularPowerDistribution angularPowerDistribution in value)
                {
                    if (Core.Query.Clone(angularPowerDistribution) is AngularPowerDistribution angularPowerDistribution_Temp)
                    {
                        dictionary[angularPowerDistribution.Delay] = angularPowerDistribution_Temp;
                    }
                }
            }
        }

        [JsonIgnore]
        public Point3D? Location
        {
            get
            {
                return Core.Query.Clone(location);
            }
        }

        public List<Ray>? GetRays(double delay)
        {
            if (double.IsNaN(delay) || location == null || dictionary == null || !dictionary.TryGetValue(delay, out AngularPowerDistribution angularPowerDistribution) || angularPowerDistribution == null)
            {
                return null;
            }

            return angularPowerDistribution.Vectors?.ConvertAll(x => new Ray(location.GetMoved(x.GetInversed()), x));
        }
    }
}