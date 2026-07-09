using DiGi.Communication.Enums;
using System;
using System.Numerics;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Complex reflection coefficient Gamma_kl for the given complex relative permittivity, angle of incidence and polarization.
        /// <para>Vertical: Gamma = (epsilon' * sin(gamma) - sqrt(epsilon' - cos^2(gamma))) / (epsilon' * sin(gamma) + sqrt(epsilon' - cos^2(gamma))).</para>
        /// <para>Horizontal: Gamma = (sin(gamma) - sqrt(epsilon' - cos^2(gamma))) / (sin(gamma) + sqrt(epsilon' - cos^2(gamma))).</para>
        /// </summary>
        /// <param name="complexRelativePermittivity">Complex relative electrical permittivity epsilon'_k of the object [-].</param>
        /// <param name="incidenceAngle">Angle of incidence gamma_kl [rad] measured from the cell plane (grazing angle).</param>
        /// <param name="polarization">Polarization type of the propagating electromagnetic wave.</param>
        /// <returns>Complex reflection coefficient [-].</returns>
        public static Complex ReflectionCoefficient(Complex complexRelativePermittivity, double incidenceAngle, Polarization polarization)
        {
            double sin = Math.Sin(incidenceAngle);
            double cos = Math.Cos(incidenceAngle);

            Complex root = Complex.Sqrt(complexRelativePermittivity - (cos * cos));

            if (polarization == Polarization.Horizontal)
            {
                return (sin - root) / (sin + root);
            }

            return ((complexRelativePermittivity * sin) - root) / ((complexRelativePermittivity * sin) + root);
        }
    }
}
