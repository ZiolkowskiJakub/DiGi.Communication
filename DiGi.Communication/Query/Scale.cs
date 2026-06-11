using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Scales the specified ray by the given factor.
        /// </summary>
        /// <param name="ray">The ray to scale.</param>
        /// <param name="factor">The scaling factor.</param>
        /// <returns>A new scaled <see cref="Ray"/>, or <see langword="null"/> if the input ray is null or the factor is NaN.</returns>
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

        /// <summary>
        /// Scales a collection of rays by the specified factor.
        /// </summary>
        /// <param name="rays">The collection of rays to scale.</param>
        /// <param name="factor">The scaling factor to apply to each ray.</param>
        /// <returns>A new list containing the scaled rays, or <see langword="null"/> if the input collection is null.</returns>
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