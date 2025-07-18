using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication
{
    public static partial class Query
    {
        public static Ray Scale(this Ray ray, double factor)
        {
            if(ray == null || double.IsNaN(factor))
            {
                return null;
            }

            if(factor == 1.0)
            {
                return new Ray(ray);
            }

            Point3D point = ray.Point;
            if(point == null)
            {
                return null;
            }

            Vector3D vector = ray.Vector;
            if (vector == null)
            {
                return null;
            }

            point = point.GetMoved(vector);

            vector = vector * factor;

            point = point.GetMoved(vector.GetInversed());

            return new Ray(point, vector);
        }

        public static List<Ray> Scale(this IEnumerable<Ray> rays, double factor)
        {
            if(rays == null)
            {
                return null;
            }

            List<Ray> result = new List<Ray>();
            foreach(Ray ray in rays)
            {
                result.Add(Scale(ray, factor));
            }

            return result;
        }
    }
}
