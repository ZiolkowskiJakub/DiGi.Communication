using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a simple multipath power delay profile that maps discrete propagation delays to their corresponding power values.
    /// </summary>
    public interface ISimpleMultipathPowerDelayProfile : IMultipathPowerDelayProfile
    {
        /// <summary>
        /// Gets the set of discrete propagation delays [s] present in the profile.
        /// </summary>
        HashSet<double>? Delays { get; }

        /// <summary>
        /// Gets the power value associated with the specified propagation delay.
        /// </summary>
        /// <param name="delay">The propagation delay [s] for which to retrieve the power.</param>
        /// <returns>The power value at the given delay.</returns>
        double GetPower(double delay);
    }
}