using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Angle of incidence gamma_kl [rad] of the ray emitted from the transmitter (placed at the origin) on the mesh cell plane, measured from the plane (grazing angle).
        /// </summary>
        /// <param name="meshCell">Mesh cell of the scattering object.</param>
        /// <returns>Angle of incidence [rad] in range [0, pi/2] or <see cref="double.NaN"/> for a degenerate cell.</returns>
        public static double IncidenceAngle(this MeshCell meshCell)
        {
            Point3D? center = meshCell.Center;
            Vector3D? normal = meshCell.Normal;
            if (center == null || normal == null)
            {
                return double.NaN;
            }

            Vector3D vector3D_Center = new(center.X, center.Y, center.Z);

            double length_Center = vector3D_Center.Length;
            double length_Normal = normal.Length;
            if (length_Center == 0 || length_Normal == 0)
            {
                return double.NaN;
            }

            double value = Math.Abs(vector3D_Center.DotProduct(normal)) / (length_Center * length_Normal);
            if (value > 1)
            {
                value = 1;
            }

            return Math.Asin(value);
        }
    }
}