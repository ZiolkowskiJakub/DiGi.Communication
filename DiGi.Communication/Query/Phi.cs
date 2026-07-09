using DiGi.Geometry.Spatial.Classes;
using System;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Azimuth angle phi [rad] of the vector in spherical coordinates, measured in the XOY plane from the OX axis.
        /// </summary>
        /// <param name="vector3D">Direction vector.</param>
        /// <returns>Azimuth angle [rad] in range (-pi, pi].</returns>
        public static double Phi(this Vector3D vector3D)
        {
            return Math.Atan2(vector3D.Y, vector3D.X);
        }
    }
}
