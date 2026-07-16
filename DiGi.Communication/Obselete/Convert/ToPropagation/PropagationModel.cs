using DiGi.Communication.Classes;
using DiGi.Communication.Enums;
using DiGi.Communication.Obselete.Classes;
using DiGi.Communication.Obselete.Delegates;
using DiGi.Communication.Obselete.Enums;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Communication.Obselete.Convert
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a geometrical propagation model into the input data of the multi-ellipsoidal propagation model.
        /// <para>The transmitter-receiver distance is taken from the locations of the transmitting and receiving antennas assigned to the first simple multipath power delay profile of the geometrical propagation model. The mesh cells of the scattering objects are expressed in the model coordinate system: the transmitter at the origin, the OX axis towards the receiver and the OZ axis as close to the world vertical as possible. The fractional powers of the power delay profile are normalized so they sum to 1.</para>
        /// <para>The frequency, polarization, electrical material properties and antenna characteristics are not part of the geometrical propagation model and have to be provided separately.</para>
        /// </summary>
        /// <param name="geometricalPropagationModel">Geometrical propagation model holding the antennas, the scattering objects and the multipath power delay profile.</param>
        /// <param name="frequency">Frequency f of the propagating electromagnetic wave [MHz].</param>
        /// <param name="polarization">Polarization type of the propagating electromagnetic wave.</param>
        /// <param name="materialProperties">Default electrical material properties applied to the mesh cells of the scattering objects.</param>
        /// <param name="receivingDirectionalCharacteristic">Normalized reception characteristic g(theta, phi) of the directional receiving antenna.</param>
        /// <param name="receivingOmnidirectionalCharacteristic">Normalized reception characteristic g_0(theta, phi) of the omnidirectional receiving antenna.</param>
        /// <param name="transmittingDirectionalCharacteristic">Normalized radiation characteristic g_T(theta, phi) of the directional transmitting antenna.</param>
        /// <param name="transmittingOmnidirectionalCharacteristic">Normalized radiation characteristic g_T0(theta, phi) of the omnidirectional transmitting antenna.</param>
        /// <param name="materialPropertiesDictionary">Optional electrical material properties per scattering object keyed by the scattering object reference. Scattering objects without an entry use the default material properties.</param>
        /// <returns>Input data of the multi-ellipsoidal propagation model or <see langword="null"/> for invalid input.</returns>
        public static PropagationModel? ToPropagation_PropagationModel(this GeometricalPropagationModel? geometricalPropagationModel, double frequency, Polarization polarization, MaterialProperties? materialProperties, AntennaCharacteristic? receivingDirectionalCharacteristic, AntennaCharacteristic? receivingOmnidirectionalCharacteristic, AntennaCharacteristic? transmittingDirectionalCharacteristic, AntennaCharacteristic? transmittingOmnidirectionalCharacteristic, Dictionary<string, MaterialProperties>? materialPropertiesDictionary = null)
        {
            if (geometricalPropagationModel == null || double.IsNaN(frequency) || frequency <= 0 || materialProperties == null)
            {
                return null;
            }

            List<SimpleMultipathPowerDelayProfile>? simpleMultipathPowerDelayProfiles = geometricalPropagationModel.GetMultipathPowerDelayProfiles<SimpleMultipathPowerDelayProfile>();
            if (simpleMultipathPowerDelayProfiles == null || simpleMultipathPowerDelayProfiles.Count == 0)
            {
                return null;
            }

            SimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile = simpleMultipathPowerDelayProfiles[0];

            HashSet<double>? delays = simpleMultipathPowerDelayProfile.Delays;
            if (delays == null || delays.Count == 0)
            {
                return null;
            }

            double powerSum = 0;
            foreach (double delay in delays)
            {
                double power = simpleMultipathPowerDelayProfile.GetPower(delay);
                if (double.IsNaN(power) || power <= 0)
                {
                    continue;
                }

                powerSum += power;
            }

            if (powerSum <= 0)
            {
                return null;
            }

            Dictionary<double, double> normalizedValues = [];
            foreach (double delay in delays.OrderBy(x => x))
            {
                double power = simpleMultipathPowerDelayProfile.GetPower(delay);
                if (double.IsNaN(power) || power <= 0)
                {
                    continue;
                }

                normalizedValues[delay] = power / powerSum;
            }

            SimpleMultipathPowerDelayProfile normalizedSimpleMultipathPowerDelayProfile = new(normalizedValues);

            List<Antenna>? antennas = geometricalPropagationModel.GetAntennas<Antenna>(simpleMultipathPowerDelayProfile);
            if (antennas == null || antennas.Count == 0)
            {
                antennas = geometricalPropagationModel.GetAntennas<Antenna>();
            }

            if (antennas == null || antennas.Count == 0)
            {
                return null;
            }

            Antenna? antenna_Transmitter = antennas.Find(x => x.Location != null && x.Functions?.Contains(Function.Transmitter) == true);
            if (antenna_Transmitter == null)
            {
                return null;
            }

            Antenna? antenna_Receiver = antennas.Find(x => x.Guid != antenna_Transmitter.Guid && x.Location != null && x.Functions?.Contains(Function.Receiver) == true);
            if (antenna_Receiver == null)
            {
                return null;
            }

            Point3D? point3D_Transmitter = antenna_Transmitter.Location;
            Point3D? point3D_Receiver = antenna_Receiver.Location;
            if (point3D_Transmitter == null || point3D_Receiver == null)
            {
                return null;
            }

            double distance = point3D_Transmitter.Distance(point3D_Receiver);
            if (distance <= 0)
            {
                return null;
            }

            Vector3D? vector3D_AxisX = (point3D_Receiver - point3D_Transmitter)?.Unit;
            if (vector3D_AxisX == null)
            {
                return null;
            }

            Vector3D vector3D_Up = new(0, 0, 1);

            Vector3D? vector3D_AxisZ = vector3D_Up - (vector3D_AxisX * vector3D_Up.DotProduct(vector3D_AxisX));
            if (vector3D_AxisZ == null || vector3D_AxisZ.Length == 0)
            {
                // The transmitter-receiver direction is vertical: the model coordinate system is undefined
                return null;
            }

            vector3D_AxisZ = vector3D_AxisZ.Unit;
            if (vector3D_AxisZ == null)
            {
                return null;
            }

            Vector3D? vector3D_AxisY = vector3D_AxisZ.CrossProduct(vector3D_AxisX);
            if (vector3D_AxisY == null)
            {
                return null;
            }

            List<MeshCell> meshCells = [];

            List<ScatteringObject>? scatteringObjects = geometricalPropagationModel.GetScatteringObjects<ScatteringObject>();
            if (scatteringObjects != null)
            {
                foreach (ScatteringObject scatteringObject in scatteringObjects)
                {
                    List<Triangle3D>? triangle3Ds = scatteringObject.Mesh3D?.GetTriangles();
                    if (triangle3Ds == null)
                    {
                        continue;
                    }

                    MaterialProperties materialProperties_ScatteringObject = materialProperties;
                    if (materialPropertiesDictionary != null && scatteringObject.Reference is string reference && materialPropertiesDictionary.TryGetValue(reference, out MaterialProperties? materialProperties_Temp) && materialProperties_Temp != null)
                    {
                        materialProperties_ScatteringObject = materialProperties_Temp;
                    }

                    foreach (Triangle3D triangle3D in triangle3Ds)
                    {
                        Point3D? point3D_Centroid = triangle3D.GetCentroid();
                        Vector3D? vector3D_Normal = triangle3D.Plane?.Normal;
                        if (point3D_Centroid == null || vector3D_Normal == null)
                        {
                            continue;
                        }

                        Vector3D? vector3D_Centroid = point3D_Centroid - point3D_Transmitter;
                        if (vector3D_Centroid == null)
                        {
                            continue;
                        }

                        Point3D point3D_Center = new(vector3D_Centroid.DotProduct(vector3D_AxisX), vector3D_Centroid.DotProduct(vector3D_AxisY), vector3D_Centroid.DotProduct(vector3D_AxisZ));
                        Vector3D vector3D_Normal_Model = new(vector3D_Normal.DotProduct(vector3D_AxisX), vector3D_Normal.DotProduct(vector3D_AxisY), vector3D_Normal.DotProduct(vector3D_AxisZ));

                        meshCells.Add(new MeshCell(point3D_Center, vector3D_Normal_Model, materialProperties_ScatteringObject));
                    }
                }
            }

            return new PropagationModel(distance, frequency, meshCells, polarization, normalizedSimpleMultipathPowerDelayProfile, receivingDirectionalCharacteristic, receivingOmnidirectionalCharacteristic, transmittingDirectionalCharacteristic, transmittingOmnidirectionalCharacteristic);
        }
    }
}