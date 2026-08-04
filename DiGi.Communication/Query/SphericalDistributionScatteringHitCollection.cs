using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Combines and retrieves a spherical distribution scattering hit collection from the specified angular power distribution profile.
        /// </summary>
        /// <param name="angularPowerDistributionProfile">The angular power distribution profile to query.</param>
        /// <returns>A <see cref="Classes.SphericalDistributionScatteringHitCollection"/> instance aggregating all scattering hits, or <see langword="null"/> if the profile or its distributions are null.</returns>
        public static SphericalDistributionScatteringHitCollection? SphericalDistributionScatteringHitCollection(this IAngularPowerDistributionProfile? angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile?.AngularPowerDistributions is not IEnumerable<AngularPowerDistribution> angularPowerDistributions)
            {
                return null;
            }

            Classes.SphericalDistributionScatteringHitCollection result = new();
            foreach (AngularPowerDistribution angularPowerDistribution in angularPowerDistributions)
            {
                if (angularPowerDistribution?.SphericalDistributionScatteringHitCollection is not Classes.SphericalDistributionScatteringHitCollection sphericalDistributionScatteringHitCollection)
                {
                    continue;
                }

                List<Range<double>>? ranges_Elevation = sphericalDistributionScatteringHitCollection.GetElevationRanges(true);
                if (ranges_Elevation is null || ranges_Elevation.Count == 0)
                {
                    continue;
                }

                List<Range<double>>? ranges_Azimuth = sphericalDistributionScatteringHitCollection.GetAzimuthRanges(true);
                if (ranges_Azimuth is null || ranges_Azimuth.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < ranges_Elevation.Count; i++)
                {
                    double elevation = (ranges_Elevation[i].Min + ranges_Elevation[i].Max) / 2.0;

                    for (int j = 0; j < ranges_Azimuth.Count; j++)
                    {
                        double azimuth = (ranges_Azimuth[j].Min + ranges_Azimuth[j].Max) / 2.0;
                        IReadOnlyList<IScatteringHit>? scatteringHits = angularPowerDistribution.GetScatteringHits(azimuth, elevation);
                        if (scatteringHits is null || scatteringHits.Count == 0)
                        {
                            continue;
                        }

                        result.AddValues(azimuth, elevation, scatteringHits);
                    }
                }
            }

            return result;
        }
    }
}
