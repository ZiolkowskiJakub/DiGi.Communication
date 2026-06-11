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
    /// Represents a scattering profile that defines the spatial characteristics and location data associated with a scattering process.
    /// </summary>
    public class ScatteringProfile : GuidObject, IScatteringProfile
    {
        [JsonInclude, JsonPropertyName("Location_1")]
        private readonly Point3D? location_1;

        [JsonInclude, JsonPropertyName("Location_2")]
        private readonly Point3D? location_2;

        [JsonIgnore]
        private SortedDictionary<double, Scattering>? dictionary;

        [JsonInclude, JsonPropertyName("Visible")]
        private readonly bool visible;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringProfile"/> class.
        /// </summary>
        /// <param name="guid">The unique identifier for the scattering profile.</param>
        /// <param name="location_1">The first point in three-dimensional space defining the location.</param>
        /// <param name="location_2">The second point in three-dimensional space defining the location.</param>
        /// <param name="visible">A value indicating whether the scattering profile is visible.</param>
        /// <param name="scatterings">A collection of scatterings associated with this profile.</param>
        public ScatteringProfile(Guid guid, Point3D? location_1, Point3D? location_2, bool visible, IEnumerable<Scattering>? scatterings)
            : base(guid)
        {
            this.visible = visible;
            this.location_1 = Core.Query.Clone(location_1);
            this.location_2 = Core.Query.Clone(location_2);
            Scatterings = scatterings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringProfile"/> class.
        /// </summary>
        /// <param name="visible">A value indicating whether the scattering profile is visible.</param>
        /// <param name="location_1">The first point in three-dimensional space defining the location.</param>
        /// <param name="location_2">The second point in three-dimensional space defining the location.</param>
        /// <param name="scatterings">A collection of scattering elements associated with this profile.</param>
        public ScatteringProfile(bool visible, Point3D? location_1, Point3D? location_2, IEnumerable<Scattering>? scatterings)
            : base()
        {
            this.visible = visible;
            this.location_1 = Core.Query.Clone(location_1);
            this.location_2 = Core.Query.Clone(location_2);
            Scatterings = scatterings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringProfile"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the profile.</param>
        public ScatteringProfile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringProfile"/> class by copying another <see cref="ScatteringProfile"/> instance.
        /// </summary>
        /// <param name="scatteringProfile">The source scattering profile to copy from, or <c>null</c> to initialize a new empty profile.</param>
        public ScatteringProfile(ScatteringProfile? scatteringProfile)
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

        /// <summary> Gets the collection of scattering entries associated with this profile. </summary>
        [JsonInclude, JsonPropertyName("Scatterings")]
        public IEnumerable<Scattering>? Scatterings
        {
            get
            {
                if (dictionary == null)
                {
                    return null;
                }

                List<Scattering> result = [];
                foreach (Scattering scattering in dictionary.Values)
                {
                    if (Core.Query.Clone(scattering) is Scattering scattering_Temp)
                    {
                        result.Add(scattering_Temp);
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

                foreach (Scattering scattering in value)
                {
                    if (Core.Query.Clone(scattering) is Scattering scattering_Temp)
                    {
                        dictionary[scattering.Delay] = scattering_Temp;
                    }
                }
            }
        }

        /// <summary> Gets a value indicating whether the scattering profile is visible. </summary>
        [JsonIgnore]
        public bool Visible
        {
            get
            {
                return visible;
            }
        }

        /// <summary> Gets the first location point in three-dimensional space associated with the scattering profile. </summary>
        [JsonIgnore]
        public Point3D? Location_1
        {
            get
            {
                return Core.Query.Clone(location_1);
            }
        }

        /// <summary> Gets the second location associated with the scattering profile. </summary>
        [JsonIgnore]
        public Point3D? Location_2
        {
            get
            {
                return Core.Query.Clone(location_2);
            }
        }
    }
}
