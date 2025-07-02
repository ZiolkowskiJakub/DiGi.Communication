using ComputeSharp;
using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.ComputeSharp.Geometry.Spatial;
using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.ComputeSharp.Spatial.Enums;
using DiGi.ComputeSharp.Spatial.Interfaces;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication
{
    public static partial class Create
    {
        public static Scattering Scattering<TScatteringObject>(EllipsoidalPropagation ellipsoidalPropagation, IEnumerable<TScatteringObject> scatteringObjects, double pointDensity = Constans.Factor.PointDensity, double angleFactor = Constans.Factor.Angle, double tolerance = Core.Constans.Tolerance.Distance) where TScatteringObject : IScatteringObject
        {
            return Scattering(ellipsoidalPropagation, scatteringObjects, out Mesh3D ellipsoidMesh3D, out List<Segment3D> intersectionSegment3Ds, pointDensity, angleFactor, tolerance);
        }

        public static Scattering Scattering<TScatteringObject>(EllipsoidalPropagation ellipsoidalPropagation, IEnumerable<TScatteringObject> scatteringObjects, out Mesh3D ellipsoidMesh3D, out List<Segment3D> intersectionSegment3Ds, double pointDensity = Constans.Factor.PointDensity, double angleFactor = Constans.Factor.Angle, double tolerance = Core.Constans.Tolerance.Distance) where TScatteringObject : IScatteringObject
        {
            ellipsoidMesh3D = null;
            intersectionSegment3Ds = null;

            if (ellipsoidalPropagation == null || scatteringObjects == null)
            {
                return null;
            }

            Ellipsoid ellipsoid = ellipsoidalPropagation.GetEllipsoid(tolerance);
            if(ellipsoid == null)
            {
                return null;
            }

            BoundingBox3D boundingBox3D = ellipsoid.GetBoundingBox();
            if(boundingBox3D == null)
            {
                return null;
            }


            List<Triangle3> triangle3s = new List<Triangle3>();
            List<string> references = new List<string>();
            List<BoundingBox3D> boundingBox3Ds = new List<BoundingBox3D>();
            foreach (TScatteringObject scatteringObject in scatteringObjects)
            {
                Mesh3D mesh3D_ScatteringObject = scatteringObject?.Mesh3D;
                if(mesh3D_ScatteringObject == null)
                {
                    continue;
                }

                string reference = scatteringObject.Reference;

                BoundingBox3D boundingBox3D_ScatteringObject = mesh3D_ScatteringObject.GetBoundingBox();

                if(!boundingBox3D.InRange(boundingBox3D_ScatteringObject, tolerance))
                {
                    continue;
                }

                List<Triangle3> triangle3s_Temp = ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(mesh3D_ScatteringObject, true);
                if(triangle3s_Temp == null)
                {
                    continue;
                }

                foreach(Triangle3 triangle3 in triangle3s_Temp)
                {
                    triangle3s.Add(triangle3);
                    references.Add(reference);
                }

                boundingBox3Ds.Add(boundingBox3D_ScatteringObject);
            }

            GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return null;
            }

            ellipsoidMesh3D = ellipsoid.Mesh3D(angleFactor);
            if(ellipsoidMesh3D == null)
            {
                return null;
            }

            List<Triangle3D> triangle3Ds_Ellipsoid = ellipsoidMesh3D.GetTriangles();
            if(triangle3Ds_Ellipsoid == null || triangle3Ds_Ellipsoid.Count == 0)
            {
                return null;
            }

            for (int i = triangle3Ds_Ellipsoid.Count - 1; i >= 0; i--)
            {
                Triangle3D triangle3D = triangle3Ds_Ellipsoid[i];

                BoundingBox3D boundingBox3D_Triangle3D = triangle3D.GetBoundingBox();

                int index = boundingBox3Ds.FindIndex(x => x.InRange(boundingBox3D_Triangle3D, tolerance));
                if(index >= 0)
                {
                    continue;
                }

                triangle3Ds_Ellipsoid.RemoveAt(i);
            }

            List<Triangle3> triangle3s_Ellipsoid = ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(triangle3Ds_Ellipsoid, true);
            if (triangle3s_Ellipsoid == null)
            {
                return null;
            }

            Point3D location_1 = ellipsoidalPropagation.Location_1;
            Point3D location_2 = ellipsoidalPropagation.Location_2;

            List<ScatteringPointGroup> scatteringPointGroups = new List<ScatteringPointGroup>();

            if (triangle3s != null && triangle3s.Count != 0)
            {
                ReadOnlyBuffer<Triangle3> readOnlyBuffer_Triangle3s = graphicsDevice.AllocateReadOnlyBuffer(triangle3s.ToArray());

                List<ScatteringPoint> scatteringPoints = new List<ScatteringPoint>();
                IEnumerable<Triangle3Intersection> triangle3Interscetions = ComputeSharp.Spatial.Create.Triangle3Intersections(graphicsDevice, triangle3s_Ellipsoid, readOnlyBuffer_Triangle3s, tolerance);
                if (triangle3Interscetions != null)
                {
                    List<Line3> line3s = new List<Line3>();
                    foreach (Triangle3Intersection triangle3Intersection in triangle3Interscetions)
                    {
                        IGeometry3[] geometry3s = triangle3Intersection.GetIntersectionGeometries();
                        if (geometry3s == null)
                        {
                            continue;
                        }

                        foreach (IGeometry3 geometry3 in geometry3s)
                        {
                            if (geometry3 is Triangle3)
                            {
                                line3s.AddRange(((Triangle3)geometry3).GetLines());
                            }
                            else if (geometry3 is Line3)
                            {
                                line3s.Add((Line3)geometry3);
                            }
                        }
                    }

                    if (line3s != null && line3s.Count != 0)
                    {
                        intersectionSegment3Ds = new List<Segment3D>();                      
                        
                        Coordinate3 location;

                        List<Tuple<Line3, Coordinate3>> tuples_1 = new List<Tuple<Line3, Coordinate3>>();
                        location = location_1.ToComputeSharp();

                        foreach (Line3 line3 in line3s)
                        {
                            intersectionSegment3Ds.Add(ComputeSharp.Geometry.Spatial.Convert.ToDiGi(line3));
                            
                            List<Coordinate3> coordinate3s = ComputeSharp.Spatial.Create.Coordinate3s(line3, LineAlignment.Center, pointDensity, true, tolerance);
                            if (coordinate3s == null)
                            {
                                continue;
                            }

                            foreach (Coordinate3 coordinate3 in coordinate3s)
                            {
                                //Coordinate3 vector = new Coordinate3(coordinate3, location).GetNormalized(tolerance).Multiply(0.1);

                                //Line3 line3_Temp = new Line3(new ComputeSharp.Core.Classes.Bool(true), location, coordinate3.GetMoved(vector));

                                Line3 line3_Temp = new Line3(new ComputeSharp.Core.Classes.Bool(true), location, coordinate3);

                                tuples_1.Add(new Tuple<Line3, Coordinate3>(line3_Temp, coordinate3));
                            }
                        }

                        if (tuples_1 != null && tuples_1.Count != 0)
                        {
                            List<bool> intersects = ComputeSharp.Spatial.Query.Intersect(graphicsDevice, tuples_1.ConvertAll(x => x.Item1), readOnlyBuffer_Triangle3s, false, false, tolerance);
                            if (intersects != null && intersects.Count != 0)
                            {
                                List<Tuple<Line3, Coordinate3>> tuples_2 = new List<Tuple<Line3, Coordinate3>>();
                                location = location_2.ToComputeSharp();
                                for (int i = 0; i < intersects.Count; i++)
                                {
                                    if (intersects[i])
                                    {
                                        continue;
                                    }

                                    Coordinate3 coordinate3 = tuples_1[i].Item2;

                                    // Coordinate3 vector = new Coordinate3(coordinate3, location).GetNormalized(tolerance).Multiply(0.1);

                                    //Line3 line3_Temp = new Line3(new ComputeSharp.Core.Classes.Bool(true), location, coordinate3.GetMoved(vector));

                                    Line3 line3_Temp = new Line3(new ComputeSharp.Core.Classes.Bool(true), location, coordinate3);

                                    tuples_2.Add(new Tuple<Line3, Coordinate3>(line3_Temp, coordinate3));
                                }

                                if (tuples_2 != null && tuples_2.Count != 0)
                                {
                                    intersects = ComputeSharp.Spatial.Query.Intersect(graphicsDevice, tuples_2.ConvertAll(x => x.Item1), readOnlyBuffer_Triangle3s, false, false, tolerance);
                                    if (intersects != null && intersects.Count != 0)
                                    {
                                        List<Coordinate3> points = new List<Coordinate3>();
                                        for (int i = 0; i < intersects.Count; i++)
                                        {
                                            if (intersects[i])
                                            {
                                                continue;
                                            }

                                            points.Add(tuples_2[i].Item2);
                                        }

                                        if (points != null && points.Count != 0)
                                        {
                                            List<int> indexes = ComputeSharp.Spatial.Query.Inside(graphicsDevice, points, readOnlyBuffer_Triangle3s, tolerance);
                                            if (indexes != null && indexes.Count != 0)
                                            {
                                                Dictionary<string, List<Coordinate3>> dictionary = new Dictionary<string, List<Coordinate3>>();
                                                for (int i = 0; i < points.Count; i++)//foreach (int index in indexes)
                                                {
                                                    int index = indexes[i];
                                                    Coordinate3 point = points[i];

                                                    string reference = index == -1 ? string.Empty : references[index];
                                                    if (reference == null)
                                                    {
                                                        reference = string.Empty;
                                                    }

                                                    if (!dictionary.TryGetValue(reference, out List<Coordinate3> points_Temp) || points_Temp == null)
                                                    {
                                                        points_Temp = new List<Coordinate3>();
                                                        dictionary[reference] = points_Temp;
                                                    }

                                                    points_Temp.Add(point);
                                                }

                                                foreach (KeyValuePair<string, List<Coordinate3>> keyValuePair in dictionary)
                                                {
                                                    scatteringPointGroups.Add(new ScatteringPointGroup(keyValuePair.Key, keyValuePair.Value.ConvertAll(x => new ScatteringPoint(ComputeSharp.Geometry.Spatial.Convert.ToDiGi(x)))));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return new Scattering(location_1, location_2, scatteringPointGroups);
        }
    }
}
