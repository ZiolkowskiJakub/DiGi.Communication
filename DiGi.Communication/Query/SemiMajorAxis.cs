namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Semi-major axis a_n [m] of the propagation ellipsoid: a_n = (c * tau_n + d) / 2.
        /// </summary>
        /// <param name="delay">Delay tau_n [s].</param>
        /// <param name="distance">Distance d between the transmitter and receiver [m].</param>
        /// <returns>Semi-major axis [m] or <see cref="double.NaN"/> for invalid input.</returns>
        public static double SemiMajorAxis(double delay, double distance)
        {
            if (delay < 0 || distance <= 0)
            {
                return double.NaN;
            }

            return 0.5 * ((Constants.Physical.LightSpeed * delay) + distance);
        }
    }
}