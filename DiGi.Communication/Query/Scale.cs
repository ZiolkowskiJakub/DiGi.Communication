using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication
{
    public static partial class Query
    {
        public static Ray? Scale(this Ray? ray, double factor)
        {
            if (ray == null || double.IsNaN(factor))
            {
                return null;
            }

            if (factor == 1.0)
            {
                return new Ray(ray);
            }

            Point3D? point = ray.Point;
            if (point == null)
            {
                return null;
            }

            Vector3D? vector = ray.Vector;
            if (vector == null)
            {
                return null;
            }

            point = point.GetMoved(vector);

            vector *= factor;

            point = point?.GetMoved(vector?.GetInversed());

            return new Ray(point, vector);
        }

        public static List<Ray>? Scale(this IEnumerable<Ray>? rays, double factor)
        {
            if (rays == null)
            {
                return null;
            }

            List<Ray> result = [];
            foreach (Ray ray in rays)
            {
                if (Scale(ray, factor) is Ray ray_Scale)
                {
                    result.Add(ray_Scale);
                }
            }

            return result;
        }
    }
}