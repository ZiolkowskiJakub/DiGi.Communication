using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication
{
    public static partial class Query
    {
        public static List<Polyline3D> Polyline3Ds(this IScatteringProfile scatteringProfile, double delay, IEnumerable<string> references = null)
        {
            if(scatteringProfile == null)
            {
                return null;
            }
            
            List<Polyline3D> result = null;

            IEnumerable<Scattering> scatterings = scatteringProfile.Scatterings;
            if (scatterings == null)
            {
                return null;
            }

            Scattering scattering = scatterings.Find(x => x.Delay == delay);
            if (scattering == null)
            {
                return null;
            }

            List<ScatteringPointGroup> scatteringPointGroups = scattering.ScatteringPointGroups;
            if (scatteringPointGroups == null)
            {
                return null;
            }

            Point3D location_1 = scatteringProfile.Location_1;
            if (location_1 == null)
            {
                return null;
            }

            Point3D location_2 = scatteringProfile.Location_2;
            if (location_2 == null)
            {
                return null;
            }

            if (references != null)
            {
                scatteringPointGroups.RemoveAll(x => !references.Contains(x.Reference));
            }

            if(scatteringPointGroups.Count == 0)
            {
                return null;
            }

            result = new List<Polyline3D>();

            foreach (ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
            {
                List<Point3D> point3Ds = scatteringPointGroup?.Points;
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
