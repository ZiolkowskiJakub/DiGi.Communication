using System.ComponentModel;

namespace DiGi.Communication.Enums
{
    /// <summary>
    /// Specifies the communication function role of a device, distinguishing between transmitter and receiver roles.
    /// </summary>
    [Description("Function")]
    public enum Function
    {
        /// <summary>
        /// Represents the transmitter function.
        /// </summary>
        [Description("Transmitter")] Transmitter,
        /// <summary>
        /// Represents the receiver function.
        /// </summary>
        [Description("Receiver")] Receiver,
    }
}