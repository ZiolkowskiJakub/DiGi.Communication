using DiGi.Communication.Obselete.Classes;
using System.Collections.Generic;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Sum of the powers assigned to the rays. For rays created from a normalized Power Delay Profile the sum equals 1.
        /// </summary>
        /// <param name="arrivalRays">Rays with assigned corrected powers p_nkl.</param>
        /// <returns>Sum of the ray powers [-] or <see cref="double.NaN"/> when rays are not provided.</returns>
        public static double TotalPower(this IEnumerable<ArrivalRay>? arrivalRays)
        {
            if (arrivalRays == null)
            {
                return double.NaN;
            }

            double result = 0;
            foreach (ArrivalRay arrivalRay in arrivalRays)
            {
                result += arrivalRay.Power;
            }

            return result;
        }
    }
}