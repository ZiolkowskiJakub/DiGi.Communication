using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a physical object that causes scattering of electromagnetic waves, defined by its mesh geometry, reference identifier, relative permittivity, and electrical conductivity.
    /// </summary>
    public interface IScatteringObject : ICommunicationGuidObject
    {
        /// <summary>
        /// Gets the 3D mesh representing the geometry of the scattering object.
        /// </summary>
        Mesh3D? Mesh3D { get; }

        /// <summary>
        /// Gets the reference identifier of the scattering object.
        /// </summary>
        string? Reference { get; }

        /// <summary>
        /// Gets the relative permittivity of the object [-].
        /// </summary>
        double RelativePermittivity { get; }

        /// <summary>
        /// Gets the electrical conductivity of the object [S/m].
        /// </summary>
        double ElectricalConductivity { get; }
    }
}