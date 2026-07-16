using DiGi.Communication.Constants;
using System;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Semi-minor axes b_n = c_n [m] of the propagation ellipsoid: b_n = sqrt(c * tau_n * (c * tau_n + 2 * d)) / 2.
        /// </summary>
        /// <param name="delay">Delay tau_n [s].</param>
        /// <param name="distance">Distance d between the transmitter and receiver [m].</param>
        /// <returns>Semi-minor axis [m] or <see cref="double.NaN"/> for invalid input.</returns>
        public static double SemiMinorAxis(double delay, double distance)
        {
            if (delay < 0 || distance <= 0)
            {
                return double.NaN;
            }

            double delayDistance = Physical.LightSpeed * delay;

            return 0.5 * Math.Sqrt(delayDistance * (delayDistance + (2.0 * distance)));
        }
    }
}