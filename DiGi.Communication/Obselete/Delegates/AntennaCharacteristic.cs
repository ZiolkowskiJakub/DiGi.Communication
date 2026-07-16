namespace DiGi.Communication.Obselete.Delegates
{
    /// <summary>
    /// Normalized antenna radiation characteristic g(theta, phi). The normalization condition is the integral of |g(theta, phi)|^2 over the full solid angle equal to 1.
    /// </summary>
    /// <param name="theta">Polar angle theta [rad] measured from the OZ axis.</param>
    /// <param name="phi">Azimuth angle phi [rad] measured in the XOY plane from the OX axis.</param>
    /// <returns>Value of the normalized radiation characteristic for the given direction.</returns>
    public delegate double AntennaCharacteristic(double theta, double phi);
}