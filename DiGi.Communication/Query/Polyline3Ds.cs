using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Communication
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a list of three-dimensional polylines from the specified scattering profile based on the provided delay and optional references.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to query for polyline data.</param>
        /// <param name="delay">The delay value used to filter or identify the polylines.</param>
        /// <param name="references">An optional collection of reference strings to further filter the results.</param>
        /// <returns>A list of <see cref="Polyline3D"/> objects if successful; otherwise, <c>null</c> if the scattering profile is null.</returns>
        public static List<Polyline3D>? Polyline3Ds(this IScatteringProfile? scatteringProfile, double delay, IEnumerable<string>? references = null)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            List<Polyline3D>? result = null;

            IEnumerable<Scattering>? scatterings = scatteringProfile.Scatterings;
            if (scatterings == null)
            {
                return null;
            }

            Scattering? scattering = scatterings.Find(x => x is not null && x.Delay == delay);
            if (scattering == null)
            {
                return null;
            }

            List<ScatteringPointGroup>? scatteringPointGroups = scattering.ScatteringPointGroups;
            if (scatteringPointGroups == null)
            {
                return null;
            }

            Point3D? location_1 = scatteringProfile.Location_1;
            if (location_1 == null)
            {
                return null;
            }

            Point3D? location_2 = scatteringProfile.Location_2;
            if (location_2 == null)
            {
                return null;
            }

            if (references != null)
            {
                scatteringPointGroups.RemoveAll(x => !references.Contains(x.Reference));
            }

            if (scatteringPointGroups.Count == 0)
            {
                return null;
            }

            result = [];

            foreach (ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
            {
                List<Point3D>? point3Ds = scatteringPointGroup?.Points;
                if (point3Ds == null || point3Ds.Count == 0)
                {
                    continue;
                }

                foreach (Point3D point3D in point3Ds)
                {
                    result.Add(new Polyline3D([location_1, point3D, location_2]));
                }
            }

            return result;
        }
    }
}