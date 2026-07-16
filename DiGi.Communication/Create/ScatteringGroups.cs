using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Core.Constants;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication
{
    public static partial class Create
    {
        /// <summary>
        /// Creates scattering groups by clustering scattering objects into connected components based on intersection of their bounding boxes expanded by the given tolerance.
        /// </summary>
        /// <param name="geometricalPropagationModel">The geometrical propagation model providing the scattering objects when <paramref name="scatteringObjects"/> is <see langword="null"/>.</param>
        /// <param name="scatteringObjects">The scattering objects to group. If <see langword="null"/>, ungrouped scattering objects of the <paramref name="geometricalPropagationModel"/> are used.</param>
        /// <param name="tolerance">The distance tolerance [m] by which bounding boxes are expanded while testing for intersection.</param>
        /// <returns>The created scattering groups if any; otherwise, <see langword="null"/>.</returns>
        public static IEnumerable<IScatteringGroup>? CreateScatteringGroups(this GeometricalPropagationModel? geometricalPropagationModel, IEnumerable<IScatteringObject>? scatteringObjects = null, double tolerance = Tolerance.Distance)
        {
            if (geometricalPropagationModel is null)
            {
                return null;
            }

            List<IScatteringObject>? scatteringObjects_Temp = scatteringObjects is null ? geometricalPropagationModel.GetScatteringObjects<IScatteringObject>(false) : new List<IScatteringObject>(scatteringObjects);
            if (scatteringObjects_Temp is null || scatteringObjects_Temp.Count == 0)
            {
                return null;
            }

            List<BoundingBox3D> boundingBox3Ds = [];
            foreach (IScatteringObject scatteringObject in scatteringObjects_Temp)
            {
                if (scatteringObject?.Mesh3D?.GetBoundingBox() is BoundingBox3D boundingBox3D)
                {
                    boundingBox3Ds.Add(boundingBox3D);
                }
            }

            if (boundingBox3Ds.Count == 0)
            {
                return null;
            }

            List<IScatteringGroup> result = [];

            bool[] visited = new bool[boundingBox3Ds.Count];
            for (int i = 0; i < boundingBox3Ds.Count; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                List<BoundingBox3D> boundingBox3Ds_Component = [];

                Queue<int> queue = new();
                queue.Enqueue(i);
                visited[i] = true;

                while (queue.Count > 0)
                {
                    int index = queue.Dequeue();

                    BoundingBox3D boundingBox3D = boundingBox3Ds[index];
                    boundingBox3Ds_Component.Add(boundingBox3D);

                    for (int j = 0; j < boundingBox3Ds.Count; j++)
                    {
                        if (visited[j])
                        {
                            continue;
                        }

                        if (boundingBox3D.InRange(boundingBox3Ds[j], tolerance))
                        {
                            visited[j] = true;
                            queue.Enqueue(j);
                        }
                    }
                }

                BoundingBox3D? boundingBox3D_Component = Geometry.Spatial.Create.BoundingBox3D(boundingBox3Ds_Component);
                if (boundingBox3D_Component is not null)
                {
                    result.Add(new ScatteringGroup(null, boundingBox3D_Component));
                }
            }

            return result;
        }
    }
}
