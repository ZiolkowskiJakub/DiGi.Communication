using DiGi.Communication.Classes;
using DiGi.Communication.Enums;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a hit resulting from scattering ray intersection, containing reference identifier, electrical properties, and ray geometry.
    /// </summary>
    public interface IScatteringHit : ICommunicationSerializableObject
    {
        /// <summary>
        /// Gets the electrical properties of the scattering object.
        /// </summary>
        ElectricalProperties? ElectricalProperties { get; }

        /// <summary>
        /// Gets the frequency in Hertz [Hz].
        /// </summary>
        double Frequency { get; }

        /// <summary>
        /// Gets the 3D location of the hit point.
        /// </summary>
        Point3D? Location { get; }

        /// <summary>
        /// Gets the 3D location of the receiver.
        /// </summary>
        Point3D? Location_Receiver { get; }

        /// <summary>
        /// Gets the 3D location of the transmitter.
        /// </summary>
        Point3D? Location_Transmitter { get; }

        /// <summary>
        /// Gets the reference identifier of the hit scattering object.
        /// </summary>
        string? Reference { get; }

        /// <summary>
        /// Calculates the azimuth angle in radians for the specified node function.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <returns>The azimuth angle in radians [0, 2π), or <see cref="double.NaN"/> if invalid.</returns>
        double GetAzimuth(Function function);

        /// <summary>
        /// Calculates the elevation angle in radians for the specified node function.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <returns>The elevation angle in radians [0, π], or <see cref="double.NaN"/> if invalid.</returns>
        double GetElevation(Function function);

        /// <summary>
        /// Gets the ray in 3D space associated with the specified node function.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <returns>The 3D ray associated with the specified node function, or <see langword="null"/> if invalid.</returns>
        Ray3D? GetRay3D(Function function);

        /// <summary>
        /// Gets the unit direction vector associated with the specified node function.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <returns>The unit direction vector, or <see langword="null"/> if invalid.</returns>
        Vector3D? GetVector3D(Function function);

        /// <summary>
        /// Calculates the material conductivity in Siemens per meter [S/m] at the operating frequency.
        /// </summary>
        /// <returns>The conductivity [S/m], or <see cref="double.NaN"/> if electrical properties are missing.</returns>
        double GetConductivity();

        /// <summary>
        /// Calculates the material relative permittivity (dielectric constant) at the operating frequency.
        /// </summary>
        /// <returns>The relative permittivity, or <see cref="double.NaN"/> if electrical properties are missing.</returns>
        double GetRelativePermittivity();

        /// <summary>
        /// Gets the surface normal unit vector at the hit point derived from specular reflection geometry.
        /// </summary>
        /// <returns>The unit surface normal vector, or <see langword="null"/> if invalid.</returns>
        Vector3D? GetNormal();

        /// <summary>
        /// Calculates the reflection angle (angle of incidence) in radians relative to the surface normal.
        /// </summary>
        /// <remarks>
        /// According to standard scientific radioscience definitions (ITU-R P.2040, IEEE Std 211), the reflection angle
        /// is the angle between the ray direction and the surface normal vector (0 rad = normal incidence, π/2 rad = parallel to surface).
        /// </remarks>
        /// <returns>The reflection angle in radians [0, π/2], or <see cref="double.NaN"/> if invalid.</returns>
        double GetReflectionAngle();

        /// <summary>
        /// Calculates the grazing angle in radians relative to the surface tangent plane.
        /// </summary>
        /// <remarks>
        /// The grazing angle is defined as (π/2 - ReflectionAngle), measuring elevation above the reflecting surface plane (0 rad = parallel to surface, π/2 rad = normal incidence).
        /// </remarks>
        /// <returns>The grazing angle in radians [0, π/2], or <see cref="double.NaN"/> if invalid.</returns>
        double GetGrazingAngle();
    }
}
