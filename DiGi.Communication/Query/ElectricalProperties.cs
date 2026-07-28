using DiGi.Communication.Classes;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the electrical conductivity sigma_k of the electrical properties [S/m].
        /// </summary>
        /// <param name="electricalProperties">The electrical properties instance.</param>
        /// <param name="frequency">Frequency in [Hz].</param>
        /// <returns>The electrical conductivity [S/m], or <see cref="double.NaN"/> if calculation inputs are invalid or <paramref name="electricalProperties"/> is null.</returns>
        public static double Conductivity(this ElectricalProperties? electricalProperties, double frequency)
        {
            if (electricalProperties == null)
            {
                return double.NaN;
            }

            return electricalProperties.GetConductivity(frequency);
        }

        /// <summary>
        /// Calculates the relative electrical permittivity epsilon_wk of the electrical properties [-].
        /// </summary>
        /// <param name="electricalProperties">The electrical properties instance.</param>
        /// <param name="frequency">Frequency in [Hz].</param>
        /// <returns>The relative electrical permittivity [-], or <see cref="double.NaN"/> if calculation inputs are invalid or <paramref name="electricalProperties"/> is null.</returns>
        public static double RelativePermittivity(this ElectricalProperties? electricalProperties, double frequency)
        {
            if (electricalProperties == null)
            {
                return double.NaN;
            }

            return electricalProperties.GetRelativePermittivity(frequency);
        }
    }
}
