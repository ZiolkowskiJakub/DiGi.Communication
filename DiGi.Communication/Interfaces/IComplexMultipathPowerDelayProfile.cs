namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a complex multipath power delay profile that can decompose into separate visible and hidden simple profiles.
    /// </summary>
    public interface IComplexMultipathPowerDelayProfile : IMultipathPowerDelayProfile
    {
        /// <summary>
        /// Gets the simple multipath power delay profile filtered by visibility.
        /// </summary>
        /// <param name="visible">If <see langword="true"/>, returns the visible component; otherwise, returns the hidden component.</param>
        /// <returns>The filtered <see cref="ISimpleMultipathPowerDelayProfile"/>, or <see langword="null"/> if not available.</returns>
        ISimpleMultipathPowerDelayProfile? GetSimpleMultipathPowerDelay(bool visible);
    }
}