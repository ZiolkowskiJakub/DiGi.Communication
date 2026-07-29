using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using System.Collections.Generic;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Builds a lookup of the electrical properties of every scattering object of the model, keyed by the scattering object reference.
        /// </summary>
        /// <remarks>
        /// The scattering objects are retrieved in a single bulk call. Resolving each <see cref="IScatteringHit.Reference"/> through
        /// <see cref="GeometricalPropagationModel.GetScatteringObjects{TScatteringObject}(string)"/> instead would clone the mesh of every
        /// candidate on each call. References are not enforced unique, so the last scattering object of a duplicated reference wins.
        /// </remarks>
        /// <param name="geometricalPropagationModel">The geometrical propagation model holding the scattering objects.</param>
        /// <returns>A dictionary mapping the scattering object reference to its electrical properties, or <c>null</c> if <paramref name="geometricalPropagationModel"/> is null or holds no scattering objects.</returns>
        public static Dictionary<string, ElectricalProperties>? ElectricalPropertiesByReference(this GeometricalPropagationModel? geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IScatteringObject>? scatteringObjects = geometricalPropagationModel.GetScatteringObjects<IScatteringObject>();
            if (scatteringObjects == null)
            {
                return null;
            }

            Dictionary<string, ElectricalProperties> result = [];
            foreach (IScatteringObject scatteringObject in scatteringObjects)
            {
                if (scatteringObject?.Reference is not string reference || string.IsNullOrWhiteSpace(reference))
                {
                    continue;
                }

                if (scatteringObject.ElectricalProperties is not ElectricalProperties electricalProperties)
                {
                    continue;
                }

                result[reference] = electricalProperties;
            }

            return result;
        }
    }
}
