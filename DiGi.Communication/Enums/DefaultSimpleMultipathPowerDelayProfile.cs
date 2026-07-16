using System.ComponentModel;

namespace DiGi.Communication.Enums
{
    /// <summary>
    /// Specifies the default simple multipath power delay profiles.
    /// </summary>
    [Description("Default simple multipath power delay profile")]
    public enum DefaultSimpleMultipathPowerDelayProfile
    {
        /// <summary>
        /// Represents the typical urban multipath power delay profile.
        /// </summary>
        [Description("Typical Urban")] TypicalUrban,

        /// <summary>
        /// Represents a bad urban multipath power delay profile.
        /// </summary>
        [Description("Bad Urban")] BadUrban,
    }
}