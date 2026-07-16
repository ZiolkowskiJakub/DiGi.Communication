using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a profile that aggregates angular power distributions at a specific location.
    /// </summary>
    public interface IAngularPowerDistributionProfile : ICommunicationGuidObject
    {
        /// <summary>
        /// Gets the spatial location of the angular power distribution profile.
        /// </summary>
        Point3D? Location { get; }

        /// <summary>
        /// Gets the collection of angular power distributions contained in this profile.
        /// </summary>
        IEnumerable<AngularPowerDistribution>? AngularPowerDistributions { get; }

        /// <summary>
        /// Retrieves the rays associated with the specified delay.
        /// </summary>
        /// <param name="delay">The propagation delay [s] for which to retrieve rays.</param>
        /// <returns>A list of rays corresponding to the given delay, or <see langword="null"/> if no rays are found.</returns>
        List<Ray>? GetRays(double delay);
    }
}