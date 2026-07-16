namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Wavelength lambda [m] of the propagating electromagnetic wave: lambda = c / f, with the frequency expressed in MHz.
        /// </summary>
        /// <param name="frequency">Frequency f of the propagating electromagnetic wave [MHz].</param>
        /// <returns>Wavelength [m] or <see cref="double.NaN"/> for a non-positive frequency.</returns>
        public static double Wavelength(double frequency)
        {
            if (frequency <= 0)
            {
                return double.NaN;
            }

            return (Constants.Physical.LightSpeed / 1e6) / frequency;
        }
    }
}