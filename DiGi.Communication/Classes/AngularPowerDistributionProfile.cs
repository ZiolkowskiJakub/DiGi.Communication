using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a profile that defines the angular power distribution associated with a specific 3D location.
    /// </summary>
    public class AngularPowerDistributionProfile : GuidObject, IAngularPowerDistributionProfile
    {
        [JsonIgnore]
        private SortedDictionary<double, AngularPowerDistribution>? dictionary;

        [JsonInclude, JsonPropertyName("Location")]
        private readonly Point3D? location;

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistributionProfile"/> class.
        /// </summary>
        /// <param name="guid">The unique identifier for the profile.</param>
        /// <param name="location">The location in three-dimensional space.</param>
        /// <param name="angularPowerDistributions">The collection of angular power distributions.</param>
        public AngularPowerDistributionProfile(Guid guid, Point3D? location, IEnumerable<AngularPowerDistribution>? angularPowerDistributions)
            : base(guid)
        {
            this.location = Core.Query.Clone(location);
            AngularPowerDistributions = angularPowerDistributions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistributionProfile"/> class.
        /// </summary>
        /// <param name="location">The location of the angular power distribution profile in three-dimensional space.</param>
        /// <param name="angularPowerDistributions">A collection of angular power distributions associated with this profile.</param>
        public AngularPowerDistributionProfile(Point3D? location, IEnumerable<AngularPowerDistribution>? angularPowerDistributions)
            : base()
        {
            this.location = Core.Query.Clone(location);
            AngularPowerDistributions = angularPowerDistributions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistributionProfile"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the profile.</param>
        public AngularPowerDistributionProfile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistributionProfile"/> class, optionally copying values from an existing profile.
        /// </summary>
        /// <param name="angularPowerDistributionProfile">The source <see cref="AngularPowerDistributionProfile"/> to copy data from, or <c>null</c> to create a new instance.</param>
        public AngularPowerDistributionProfile(AngularPowerDistributionProfile? angularPowerDistributionProfile)
            : base(angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile != null)
            {
                location = angularPowerDistributionProfile.Location;
                AngularPowerDistributions = angularPowerDistributionProfile.dictionary?.Values;
            }
        }

        /// <summary> Gets or sets the collection of angular power distributions associated with this profile. </summary>
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

        /// <summary> Gets the location of the angular power distribution profile in three-dimensional space. </summary>
        [JsonIgnore]
        public Point3D? Location
        {
            get
            {
                return Core.Query.Clone(location);
            }
        }

        /// <summary>
        /// Retrieves a list of rays associated with the specified delay.
        /// </summary>
        /// <param name="delay">The time delay used to look up the angular power distribution.</param>
        /// <returns>A list of <see cref="Ray"/> objects if the distribution is found for the given delay; otherwise, <c>null</c>.</returns>
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