using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a scattering profile that describes the scattering characteristics between two locations.
    /// </summary>
    public interface IScatteringProfile : ICommunicationGuidObject
    {
        /// <summary>
        /// Gets the collection of scattering events contained in this profile.
        /// </summary>
        IEnumerable<Scattering>? Scatterings { get; }

        /// <summary>
        /// Gets whether the scattering profile is visible (line-of-sight component).
        /// </summary>
        bool Visible { get; }

        /// <summary>
        /// Gets the first (transmitter-side) spatial location of the scattering profile.
        /// </summary>
        Point3D? Location_1 { get; }

        /// <summary>
        /// Gets the second (receiver-side) spatial location of the scattering profile.
        /// </summary>
        Point3D? Location_2 { get; }
    }
}