using DiGi.Communication.Classes;
using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using System.Collections.Generic;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Combines and retrieves a spherical distribution scattering hit collection across all delays in the specified angular power distribution profile.
        /// </summary>
        /// <param name="angularPowerDistributionProfile">The angular power distribution profile to query.</param>
        /// <param name="function">The node function (Transmitter or Receiver) used for spatial hit positioning.</param>
        /// <returns>A <see cref="Classes.SphericalDistributionScatteringHitCollection"/> instance aggregating all scattering hits, or <see langword="null"/> if the profile or its distributions are null or contain no hits.</returns>
        public static SphericalDistributionScatteringHitCollection? SphericalDistributionScatteringHitCollection(this IAngularPowerDistributionProfile? angularPowerDistributionProfile, Function function = Function.Receiver)
        {
            if (angularPowerDistributionProfile?.AngularPowerDistributions is not IEnumerable<AngularPowerDistribution> angularPowerDistributions)
            {
                return null;
            }

            SphericalDistributionScatteringHitCollection result = new();
            int count_AddedHits = 0;

            foreach (AngularPowerDistribution angularPowerDistribution in angularPowerDistributions)
            {
                if (angularPowerDistribution?.SphericalDistributionScatteringHitCollection?.Values is not IReadOnlyList<IScatteringHit> scatteringHits)
                {
                    continue;
                }

                foreach (IScatteringHit scatteringHit in scatteringHits)
                {
                    if (scatteringHit is null)
                    {
                        continue;
                    }

                    result.AddValue(function, scatteringHit);
                    count_AddedHits++;
                }
            }

            return count_AddedHits > 0 ? result : null;
        }
    }
}
