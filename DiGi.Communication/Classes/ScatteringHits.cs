using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class ScatteringHits : SerializableObject, IScatteringHits
    {
        [JsonInclude, JsonPropertyName(nameof(ElectricalProperties))]
        private readonly ElectricalProperties? electricalProperties;

        [JsonInclude, JsonPropertyName(nameof(Frequency))]
        private readonly double frequency;

        [JsonInclude, JsonPropertyName(nameof(Location_Receiver))]
        private readonly Point3D? location_Receiver;

        [JsonInclude, JsonPropertyName(nameof(Location_Transmitter))]
        private readonly Point3D? location_Transmitter;

        [JsonInclude, JsonPropertyName(nameof(Locations))]
        private readonly List<Point3D>? locations;
        
        [JsonInclude, JsonPropertyName(nameof(Reference))]
        private readonly string? reference;

        public ScatteringHits(string? reference, ElectricalProperties? electricalProperties, double frequency, Point3D? location_Transmitter, Point3D? location_Receiver, IEnumerable<Point3D>? locations)
            : base()
        {
            this.reference = reference;
            this.electricalProperties = Core.Query.Clone(electricalProperties);
            this.frequency = frequency;
            this.location_Transmitter = Core.Query.Clone(location_Transmitter);
            this.location_Receiver = Core.Query.Clone(location_Receiver);
            this.locations = locations == null ? null : [.. locations];
        }

        public ScatteringHits(ScatteringHits? scatteringHits)
            : base(scatteringHits)
        {
            if (scatteringHits != null)
            {
                reference = scatteringHits.reference;
                frequency = scatteringHits.frequency;
                electricalProperties = scatteringHits.ElectricalProperties;
                location_Transmitter = scatteringHits.Location_Transmitter;
                location_Receiver = scatteringHits.Location_Receiver;
                locations = scatteringHits.Locations;
            }
        }

        public ScatteringHits(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the number of hit locations.
        /// </summary>
        public int Count
        {
            get
            {
                return locations == null ? 0 : locations.Count;
            }
        }

        /// <summary>
        /// Gets the electrical properties of the scattering object.
        /// </summary>
        [JsonIgnore]
        public ElectricalProperties? ElectricalProperties
        {
            get
            {
                return Core.Query.Clone(electricalProperties);
            }
        }

        /// <summary>
        /// Gets the frequency in Hertz [Hz].
        /// </summary>
        [JsonIgnore]
        public double Frequency
        {
            get
            {
                return frequency;
            }
        }

        /// <summary>
        /// Gets the 3D location of the receiver.
        /// </summary>
        [JsonIgnore]
        public Point3D? Location_Receiver
        {
            get
            {
                return Core.Query.Clone(location_Receiver);
            }
        }

        /// <summary>
        /// Gets the 3D location of the transmitter.
        /// </summary>
        [JsonIgnore]
        public Point3D? Location_Transmitter
        {
            get
            {
                return Core.Query.Clone(location_Transmitter);
            }
        }

        /// <summary>
        /// Gets the list of 3D hit locations.
        /// </summary>
        [JsonIgnore]
        public List<Point3D>? Locations
        {
            get
            {
                return locations?.CloneAndFilterNulls();
            }
        }

        /// <summary> 
        /// Gets the reference identifier of the hit scattering object. 
        /// </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }

        /// <summary>
        /// Gets the 3D location at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index.</param>
        /// <returns>The 3D location, or <see langword="null"/> if out of range.</returns>
        public Point3D? this[int index]
        {
            get
            {
                return Core.Query.Clone(locations?[index]);
            }
        }

        /// <summary>
        /// Calculates the azimuth angle in radians for the specified node function and hit index.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <param name="index">The zero-based location index.</param>
        /// <returns>The azimuth angle in radians [0, 2π), or <see cref="double.NaN"/> if invalid.</returns>
        public double GetAzimuth(Function function, int index)
        {
            return GetAzimuth(function, this[index]);
        }

        /// <summary>
        /// Calculates the azimuth angle in radians for the specified node function and reference 3D point.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <param name="point3D">The reference 3D point.</param>
        /// <returns>The azimuth angle in radians [0, 2π), or <see cref="double.NaN"/> if invalid.</returns>
        public double GetAzimuth(Function function, Point3D? point3D)
        {
            Vector3D? vector3D = GetVector3D(function, point3D);
            if (vector3D is null)
            {
                return double.NaN;
            }

            double result = Math.Atan2(vector3D.Y, vector3D.X);
            if (result < 0)
            {
                result += Math.PI * 2;
            }

            return result;
        }

        /// <summary>
        /// Calculates the elevation angle in radians for the specified node function and hit index.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <param name="index">The zero-based location index.</param>
        /// <returns>The elevation angle in radians [0, π], or <see cref="double.NaN"/> if invalid.</returns>
        public double GetElevation(Function function, int index)
        {
            return GetElevation(function, this[index]);
        }

        /// <summary>
        /// Calculates the elevation angle in radians for the specified node function and reference 3D point.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <param name="point3D">The reference 3D point.</param>
        /// <returns>The elevation angle in radians [0, π], or <see cref="double.NaN"/> if invalid.</returns>
        public double GetElevation(Function function, Point3D? point3D)
        {
            Vector3D? vector3D = GetVector3D(function, point3D);
            if (vector3D is null)
            {
                return double.NaN;
            }

            return Math.Acos(vector3D.Z / vector3D.Length);
        }

        /// <summary>
        /// Gets the ray in 3D space associated with the specified node function and hit index.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <param name="index">The zero-based location index.</param>
        /// <returns>The 3D ray, or <see langword="null"/> if invalid.</returns>
        public Ray3D? GetRay3D(Function function, int index)
        {
            return GetRay3D(function, this[index]);
        }

        /// <summary>
        /// Gets the ray in 3D space associated with the specified node function and reference 3D point.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <param name="point3D">The reference 3D point.</param>
        /// <returns>The 3D ray, or <see langword="null"/> if invalid.</returns>
        public Ray3D? GetRay3D(Function function, Point3D? point3D)
        {
            if (GetVector3D(function, point3D)?.Unit is not Vector3D vector3D)
            {
                return null;
            }

            switch (function)
            {
                case Function.Receiver:

                    if (location_Receiver is null)
                    {
                        return null;
                    }

                    return new(location_Receiver.GetMoved(vector3D.GetInversed()), vector3D);

                case Function.Transmitter:

                    if (location_Transmitter is null)
                    {
                        return null;
                    }

                    return new(location_Transmitter, vector3D);
            }

            return null;
        }

        /// <summary>
        /// Gets the unit direction vector associated with the specified node function and hit index.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <param name="index">The zero-based location index.</param>
        /// <returns>The unit direction vector, or <see langword="null"/> if invalid.</returns>
        public Vector3D? GetVector3D(Function function, int index)
        {
            return GetVector3D(function, this[index]);
        }

        /// <summary>
        /// Gets the unit direction vector associated with the specified node function and reference 3D point.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <param name="point3D">The reference 3D point.</param>
        /// <returns>The unit direction vector, or <see langword="null"/> if invalid.</returns>
        public Vector3D? GetVector3D(Function function, Point3D? point3D)
        {
            if (point3D is null)
            {
                return null;
            }

            switch (function)
            {
                case Function.Receiver:

                    if (location_Receiver is null)
                    {
                        return null;
                    }

                    if (new Vector3D(point3D, location_Receiver).Unit is Vector3D vector3D_Receiver)
                    {
                        return vector3D_Receiver;
                    }

                    return null;

                case Function.Transmitter:

                    if (location_Transmitter is null)
                    {
                        return null;
                    }

                    if (new Vector3D(location_Transmitter, point3D).Unit is Vector3D vector3D_Transmitter)
                    {
                        return vector3D_Transmitter;
                    }

                    return null;
            }

            return null;
        }
    }
}
