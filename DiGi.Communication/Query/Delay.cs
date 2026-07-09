using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Excess propagation delay tau [s] of the mesh cell relative to the direct transmitter-receiver path: tau = (r_1 + r_2 - d) / c, with r_1 and r_2 the distances from the transmitter (origin) and receiver to the cell center.
        /// </summary>
        /// <param name="meshCell">Mesh cell of the scattering object.</param>
        /// <param name="distance">Distance d between the transmitter and receiver [m].</param>
        /// <returns>Excess propagation delay [s] or <see cref="double.NaN"/> for invalid input.</returns>
        public static double Delay(this MeshCell meshCell, double distance)
        {
            Point3D? center = meshCell.Center;
            if (center == null || distance <= 0)
            {
                return double.NaN;
            }

            Point3D point3D_Transmitter = new(0, 0, 0);
            Point3D point3D_Receiver = new(distance, 0, 0);

            double distance_Transmitter = center.Distance(point3D_Transmitter);
            double distance_Receiver = center.Distance(point3D_Receiver);

            return (distance_Transmitter + distance_Receiver - distance) / Constants.Physical.LightSpeed;
        }
    }
}
