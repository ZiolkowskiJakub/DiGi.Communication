using DiGi.Communication.Classes;
using System.Numerics;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Complex relative electrical permittivity epsilon'_k = epsilon_wk - j * 60 * lambda * sigma_k of the scattering object.
        /// </summary>
        /// <param name="materialProperties">Electrical material properties of the object.</param>
        /// <param name="wavelength">Wavelength lambda of the propagating electromagnetic wave [m].</param>
        /// <returns>Complex relative electrical permittivity [-].</returns>
        public static Complex ComplexRelativePermittivity(this MaterialProperties materialProperties, double wavelength)
        {
            return new Complex(materialProperties.RelativePermittivity, -60.0 * wavelength * materialProperties.Conductivity);
        }
    }
}