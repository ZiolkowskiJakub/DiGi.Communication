using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a complex multipath power delay profile that manages both visible and hidden
    /// simple multipath power delay profiles for communication signal analysis.
    /// </summary>
    public class ComplexMultipathPowerDelayProfile : GuidObject, IComplexMultipathPowerDelayProfile
    {
        [JsonInclude, JsonPropertyName("SimpleMultipathPowerDelayProfile_Hidden")]
        private readonly ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Hidden;

        [JsonInclude, JsonPropertyName("SimpleMultipathPowerDelayProfile_Visible")]
        private readonly ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Visible;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexMultipathPowerDelayProfile"/> class.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="simpleMultipathPowerDelayProfile_Visible">The visible simple multipath power delay profile.</param>
        /// <param name="simpleMultipathPowerDelayProfile_Hidden">The hidden simple multipath power delay profile.</param>
        public ComplexMultipathPowerDelayProfile(Guid guid, ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Visible, ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Hidden)
            : base(guid)
        {
            this.simpleMultipathPowerDelayProfile_Visible = Core.Query.Clone(simpleMultipathPowerDelayProfile_Visible);
            this.simpleMultipathPowerDelayProfile_Hidden = Core.Query.Clone(simpleMultipathPowerDelayProfile_Hidden);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexMultipathPowerDelayProfile"/> class using the specified visible and hidden simple multipath power delay profiles.
        /// </summary>
        /// <param name="simpleMultipathPowerDelayProfile_Visible">The visible simple multipath power delay profile to be cloned and assigned.</param>
        /// <param name="simpleMultipathPowerDelayProfile_Hidden">The hidden simple multipath power delay profile to be cloned and assigned.</param>
        public ComplexMultipathPowerDelayProfile(ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Visible, ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Hidden)
            : base()
        {
            this.simpleMultipathPowerDelayProfile_Visible = Core.Query.Clone(simpleMultipathPowerDelayProfile_Visible);
            this.simpleMultipathPowerDelayProfile_Hidden = Core.Query.Clone(simpleMultipathPowerDelayProfile_Hidden);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexMultipathPowerDelayProfile"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the current instance.</param>
        public ComplexMultipathPowerDelayProfile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexMultipathPowerDelayProfile"/> class by copying another instance.
        /// </summary>
        /// <param name="complexMultipathPowerDelayProfile">The source <see cref="ComplexMultipathPowerDelayProfile"/> object to copy from, or null to create an empty instance.</param>
        public ComplexMultipathPowerDelayProfile(ComplexMultipathPowerDelayProfile? complexMultipathPowerDelayProfile)
            : base(complexMultipathPowerDelayProfile)
        {
            if (complexMultipathPowerDelayProfile != null)
            {
                simpleMultipathPowerDelayProfile_Visible = Core.Query.Clone(complexMultipathPowerDelayProfile.simpleMultipathPowerDelayProfile_Visible);
                simpleMultipathPowerDelayProfile_Hidden = Core.Query.Clone(complexMultipathPowerDelayProfile.simpleMultipathPowerDelayProfile_Hidden);
            }
        }

        /// <summary>
        /// Retrieves a clone of the simple multipath power delay profile based on the specified visibility.
        /// </summary>
        /// <param name="visible">A value indicating whether to retrieve the visible (<c>true</c>) or hidden (<c>false</c>) profile.</param>
        /// <returns>The cloned <see cref="ISimpleMultipathPowerDelayProfile"/> corresponding to the requested visibility, or <c>null</c> if it does not exist.</returns>
        public ISimpleMultipathPowerDelayProfile? GetSimpleMultipathPowerDelay(bool visible)
        {
            return visible ? Core.Query.Clone(simpleMultipathPowerDelayProfile_Visible) : Core.Query.Clone(simpleMultipathPowerDelayProfile_Hidden);
        }
    }
}