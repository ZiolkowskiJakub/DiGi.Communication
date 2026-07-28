using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a hit resulting from scattering ray intersection, containing a reference identifier and ray geometry.
    /// </summary>
    public interface IScatteringHit : ICommunicationSerializableObject
    {
        /// <summary>
        /// Gets the ray in three-dimensional space associated with the hit.
        /// </summary>
        Ray3D? Ray3D { get; }

        /// <summary>
        /// Gets the reference identifier of the hit scattering object.
        /// </summary>
        string? Reference { get; }
    }
}
