using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using System.Collections.Generic;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Groups scattering hits extracted from an angular power distribution at specified azimuth and elevation angles by the electrical properties of their corresponding scattering objects in the model.
        /// </summary>
        /// <typeparam name="TScatteringHit">The type of scattering hit to extract, which must implement <see cref="IScatteringHit"/>.</typeparam>
        /// <param name="geometricalPropagationModel">The geometrical propagation model containing the scattering objects.</param>
        /// <param name="angularPowerDistribution">The angular power distribution from which scattering hits are extracted.</param>
        /// <param name="azimuth">The azimuth angle in radians.</param>
        /// <param name="elevation">The elevation angle in radians.</param>
        /// <returns>A dictionary mapping each unique <see cref="ElectricalProperties"/> to a list of matching scattering hits, or <see langword="null"/> if inputs are null or angles are invalid.</returns>
        public static Dictionary<ElectricalProperties, List<TScatteringHit>>? ScatteringHitsByElectricalProperties<TScatteringHit>(this GeometricalPropagationModel geometricalPropagationModel, AngularPowerDistribution? angularPowerDistribution, double azimuth, double elevation) where TScatteringHit : IScatteringHit
        {
            if (geometricalPropagationModel is null || angularPowerDistribution is null || double.IsNaN(azimuth) || double.IsNaN(elevation) || double.IsInfinity(azimuth) || double.IsInfinity(elevation))
            {
                return null;
            }

            IEnumerable<IScatteringHit>? scatteringHits = angularPowerDistribution.GetValues(azimuth, elevation);
            if (scatteringHits is null)
            {
                return null;
            }

            Dictionary<string, List<IScatteringObject>?> dictionary = [];

            Dictionary<ElectricalProperties, List<TScatteringHit>> result = [];
            foreach (IScatteringHit scatteringHit in scatteringHits)
            {
                if (scatteringHit is not TScatteringHit scatteringHit_Temp)
                {
                    continue;
                }

                string reference = scatteringHit.Reference ?? string.Empty;

                if (!dictionary.TryGetValue(reference, out List<IScatteringObject>? scatteringObjects))
                {
                    scatteringObjects = geometricalPropagationModel.GetScatteringObjects<IScatteringObject>(reference);
                    dictionary[reference] = scatteringObjects;
                }

                if (scatteringObjects is null || scatteringObjects.Count == 0)
                {
                    continue;
                }

                foreach (IScatteringObject scatteringObject in scatteringObjects)
                {
                    if (scatteringObject?.ElectricalProperties is not ElectricalProperties electricalProperties)
                    {
                        continue;
                    }

                    if (!result.TryGetValue(electricalProperties, out List<TScatteringHit>? scatteringHits_ElectricalProperties))
                    {
                        scatteringHits_ElectricalProperties = [];
                        result[electricalProperties] = scatteringHits_ElectricalProperties;
                    }

                    if (!scatteringHits_ElectricalProperties.Contains(scatteringHit_Temp))
                    {
                        scatteringHits_ElectricalProperties.Add(scatteringHit_Temp);
                    }
                }
            }

            return result;
        }
    }
}
