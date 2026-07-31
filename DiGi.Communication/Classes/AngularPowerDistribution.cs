using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents the angular power distribution, encapsulating the time delay and the associated spherical distribution scattering hit collection.
    /// </summary>
    public class AngularPowerDistribution : SerializableObject, IAngularPowerDistribution
    {
        [JsonInclude, JsonPropertyName(nameof(Delay))]
        private readonly double delay;

        [JsonInclude, JsonPropertyName(nameof(SphericalDistributionScatteringHitCollection))]
        private readonly SphericalDistributionScatteringHitCollection? sphericalDistributionScatteringHitCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistribution"/> class.
        /// </summary>
        /// <param name="delay">The delay value for the power distribution.</param>
        /// <param name="sphericalDistributionScatteringHitCollection">A spherical distribution scattering hit collection defining the angular power distribution.</param>
        public AngularPowerDistribution(double delay, SphericalDistributionScatteringHitCollection? sphericalDistributionScatteringHitCollection)
            : base()
        {
            this.delay = delay;
            this.sphericalDistributionScatteringHitCollection = Core.Query.Clone(sphericalDistributionScatteringHitCollection);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistribution"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the current instance.</param>
        public AngularPowerDistribution(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistribution"/> class by copying values from an existing instance.
        /// </summary>
        /// <param name="angularPowerDistribution">The source <see cref="AngularPowerDistribution"/> instance to copy data from, or <see langword="null"/>.</param>
        public AngularPowerDistribution(AngularPowerDistribution? angularPowerDistribution)
            : base(angularPowerDistribution)
        {
            if (angularPowerDistribution != null)
            {
                delay = angularPowerDistribution.delay;
                sphericalDistributionScatteringHitCollection = Core.Query.Clone(angularPowerDistribution.sphericalDistributionScatteringHitCollection);
            }
        }

        /// <summary> 
        /// Gets the delay associated with the angular power distribution. 
        /// </summary>
        [JsonIgnore]
        public double Delay
        {
            get
            {
                return delay;
            }
        }

        /// <summary>
        /// Gets the spherical distribution scattering hit collection.
        /// </summary>
        [JsonIgnore]
        public SphericalDistributionScatteringHitCollection? SphericalDistributionScatteringHitCollection
        {
            get
            {
                return Core.Query.Clone(sphericalDistributionScatteringHitCollection);
            }
        }

        /// <summary>
        /// Gets the collection of direction vectors extracted from stored scattering hits.
        /// </summary>
        public IReadOnlyList<Vector3D>? Vectors
        {
            get
            {
                if (sphericalDistributionScatteringHitCollection?.Values is not IReadOnlyList<IScatteringHit> scatteringHits)
                {
                    return null;
                }

                List<Vector3D> result = [];
                foreach (IScatteringHit scatteringHit in scatteringHits)
                {
                    if (scatteringHit?.GetVector3D(Function.Receiver) is not Vector3D vector3D)
                    {
                        continue;
                    }

                    result.Add(vector3D);
                }

                return result;
            }
        }

        /// <summary>
        /// Gets the azimuth ranges defined in the spherical distribution scattering hit collection.
        /// </summary>
        /// <param name="populatedOnly">If set to <see langword="true"/>, returns only ranges that contain scattering hits.</param>
        /// <returns>A collection of azimuth ranges, or <see langword="null"/> if no collection exists.</returns>
        public IReadOnlyList<Range<double>>? GetAzimuthRanges(bool populatedOnly = false)
        {
            if (sphericalDistributionScatteringHitCollection == null)
            {
                return null;
            }

            return sphericalDistributionScatteringHitCollection.GetAzimuthRanges(populatedOnly);
        }

        /// <summary>
        /// Gets the elevation ranges defined in the spherical distribution scattering hit collection.
        /// </summary>
        /// <param name="populatedOnly">If set to <see langword="true"/>, returns only ranges that contain scattering hits.</param>
        /// <returns>A collection of elevation ranges, or <see langword="null"/> if no collection exists.</returns>
        public IReadOnlyList<Range<double>>? GetElevationRanges(bool populatedOnly = false)
        {
            if (sphericalDistributionScatteringHitCollection == null)
            {
                return null;
            }

            return sphericalDistributionScatteringHitCollection.GetElevationRanges(populatedOnly);
        }

        /// <summary>
        /// Gets the scattering hits for the specified azimuth and elevation angles.
        /// </summary>
        /// <param name="azimuth">The azimuth angle [rad].</param>
        /// <param name="elevation">The elevation angle [rad].</param>
        /// <returns>A collection of <see cref="IScatteringHits"/> instances for the specified angles, or <see langword="null"/> if none exist.</returns>
        public IReadOnlyList<IScatteringHit>? GetScatteringHits(double azimuth, double elevation)
        {
            if (sphericalDistributionScatteringHitCollection == null)
            {
                return null;
            }

            return sphericalDistributionScatteringHitCollection.GetValues(azimuth, elevation);
        }

        /// <summary>
        /// Gets the scattering hits for the specified azimuth and elevation angle ranges.
        /// </summary>
        /// <param name="azimuthRange">The azimuth angle range [rad].</param>
        /// <param name="elevationRange">The elevation angle range [rad].</param>
        /// <returns>A collection of <see cref="IScatteringHits"/> instances for the specified angle ranges, or <see langword="null"/> if none exist.</returns>
        public IReadOnlyList<IScatteringHit>? GetValues(Range<double>? azimuthRange, Range<double>? elevationRange)
        {
            if (sphericalDistributionScatteringHitCollection == null)
            {
                return null;
            }

            return sphericalDistributionScatteringHitCollection.GetValues(azimuthRange, elevationRange);
        }

        /// <summary>
        /// Gets the scattering hits for the specified azimuth and elevation angles.
        /// </summary>
        /// <param name="azimuth">The azimuth angle [rad].</param>
        /// <param name="elevation">The elevation angle [rad].</param>
        /// <returns>A collection of <see cref="IScatteringHits"/> instances for the specified angles, or <see langword="null"/> if none exist.</returns>
        public IReadOnlyList<IScatteringHit>? GetValues(double azimuth, double elevation)
        {
            if (sphericalDistributionScatteringHitCollection == null)
            {
                return null;
            }

            return sphericalDistributionScatteringHitCollection.GetValues(azimuth, elevation);
        }
    }
}