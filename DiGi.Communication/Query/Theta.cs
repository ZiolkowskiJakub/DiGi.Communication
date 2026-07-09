using DiGi.Geometry.Spatial.Classes;
using System;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Polar angle theta [rad] of the vector in spherical coordinates, measured from the OZ axis.
        /// </summary>
        /// <param name="vector3D">Direction vector.</param>
        /// <returns>Polar angle [rad] in range [0, pi] or <see cref="double.NaN"/> for a zero-length vector.</returns>
        public static double Theta(this Vector3D vector3D)
        {
            double length = vector3D.Length;
            if (length == 0)
            {
                return double.NaN;
            }

            double value = vector3D.Z / length;
            if (value > 1)
            {
                value = 1;
            }
            else if (value < -1)
            {
                value = -1;
            }

            return Math.Acos(value);
        }
    }
}
