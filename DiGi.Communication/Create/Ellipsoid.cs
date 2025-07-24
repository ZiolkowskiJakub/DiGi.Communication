using DiGi.Communication.Interfaces;
using DiGi.Core.Constans;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication
{
    public static partial class Create
    {
        /// <summary>
        /// Propagation ellipsoid for two antennas and given delay
        /// </summary>
        /// <param name="antenna_1">First antenna</param>
        /// <param name="antenna_2">Second antenna</param>
        /// <param name="delay">Delay [m]</param>
        /// <param name="tolerance">Tolerance [m]</param>
        /// <returns></returns>
        public static Ellipsoid Ellipsoid(IAntenna antenna_1, IAntenna antenna_2, double delay, double tolerance = Tolerance.Distance)
        {
            if(antenna_1 == null || antenna_2 == null || double.IsNaN(delay))
            {
                return null;
            }

            Point3D location_1 = antenna_1.Location;
            if(location_1 == null)
            {
                return null;
            }

            Point3D location_2 = antenna_2.Location;
            if(location_2 == null)
            {
                return null;
            }

            return Ellipsoid(location_1, location_2, delay, tolerance);
        }

        /// <summary>
        /// Propagation ellipsoid for two antennas and given delay
        /// </summary>
        /// <param name="location_1">First location</param>
        /// <param name="location_2">Second location</param>
        /// <param name="delay">Delay [m]</param>
        /// <param name="tolerance">Tolerance [m]</param>
        /// <returns></returns>
        public static Ellipsoid Ellipsoid(Point3D location_1, Point3D location_2, double delay, double tolerance = Tolerance.Distance)
        {
            if (location_1 == null || location_2 == null || double.IsNaN(delay))
            {
                return null;
            }

            double distance = location_1.Distance(location_2);
            if (distance <= tolerance)
            {
                return null;
            }

            double a = ((Constans.Physical.LightSpeed * delay) + distance) / 2;
            double b = Math.Sqrt(Constans.Physical.LightSpeed * delay * ((Constans.Physical.LightSpeed * delay) + (2 * distance))) / 2;

            Point3D center = location_1.Mid(location_2);

            Vector3D directionA = new Vector3D(location_1, location_2).Unit;

            Vector3D directionB = directionA.Similar(Geometry.Spatial.Constans.Vector3D.WorldZ, tolerance) ? directionA.CrossProduct(Geometry.Spatial.Constans.Vector3D.WorldY).Unit : directionA.CrossProduct(Geometry.Spatial.Constans.Vector3D.WorldZ).Unit;

            Plane plane = new Plane(center, directionA, directionB);

            return new Ellipsoid(plane, a, b, b);
        }

    }
}
