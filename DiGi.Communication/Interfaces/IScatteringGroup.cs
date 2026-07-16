using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a group of scattering objects, defined by a bounding box and a reference identifier.
    /// </summary>
    public interface IScatteringGroup : ICommunicationGuidObject
    {
        /// <summary>
        /// Gets the 3D bounding box that encloses the scattering group.
        /// </summary>
        BoundingBox3D? BoundingBox3D { get; }

        /// <summary>
        /// Gets the reference identifier of the scattering group.
        /// </summary>
        string? Reference { get; }
    }
}