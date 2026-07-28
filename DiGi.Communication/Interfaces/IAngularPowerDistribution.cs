using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for an angular power distribution at a given delay, describing power arrival directions as a set of vectors.
    /// </summary>
    public interface IAngularPowerDistribution : ICommunicationSerializableObject
    {
        /// <summary>
        /// Gets the propagation delay associated with this power distribution [s].
        /// </summary>
        double Delay { get; }

        /// <summary>
        /// Gets the collection of direction vectors extracted from stored scattering hits.
        /// </summary>
        IReadOnlyList<Vector3D>? Vectors { get; }

        /// <summary>
        /// Gets the azimuth ranges defined in the spherical distribution scattering hit collection.
        /// </summary>
        /// <param name="populatedOnly">If set to <see langword="true"/>, returns only ranges that contain scattering hits.</param>
        /// <returns>A collection of azimuth ranges, or <see langword="null"/> if no collection exists.</returns>
        IReadOnlyList<Range<double>>? GetAzimuthRanges(bool populatedOnly = false);

        /// <summary>
        /// Gets the elevation ranges defined in the spherical distribution scattering hit collection.
        /// </summary>
        /// <param name="populatedOnly">If set to <see langword="true"/>, returns only ranges that contain scattering hits.</param>
        /// <returns>A collection of elevation ranges, or <see langword="null"/> if no collection exists.</returns>
        IReadOnlyList<Range<double>>? GetElevationRanges(bool populatedOnly = false);

        /// <summary>
        /// Gets the scattering hits for the specified azimuth and elevation angles.
        /// </summary>
        /// <param name="azimuth">The azimuth angle [rad].</param>
        /// <param name="elevation">The elevation angle [rad].</param>
        /// <returns>A collection of <see cref="IScatteringHit"/> instances for the specified angles, or <see langword="null"/> if none exist.</returns>
        IReadOnlyList<IScatteringHit>? GetScatteringHits(double azimuth, double elevation);

        /// <summary>
        /// Gets the scattering hits for the specified azimuth and elevation angle ranges.
        /// </summary>
        /// <param name="azimuthRange">The azimuth angle range [rad].</param>
        /// <param name="elevationRange">The elevation angle range [rad].</param>
        /// <returns>A collection of <see cref="IScatteringHit"/> instances for the specified angle ranges, or <see langword="null"/> if none exist.</returns>
        IReadOnlyList<IScatteringHit>? GetValues(Range<double>? azimuthRange, Range<double>? elevationRange);

        /// <summary>
        /// Gets the scattering hits for the specified azimuth and elevation angles.
        /// </summary>
        /// <param name="azimuth">The azimuth angle [rad].</param>
        /// <param name="elevation">The elevation angle [rad].</param>
        /// <returns>A collection of <see cref="IScatteringHit"/> instances for the specified angles, or <see langword="null"/> if none exist.</returns>
        IReadOnlyList<IScatteringHit>? GetValues(double azimuth, double elevation);
    }
}