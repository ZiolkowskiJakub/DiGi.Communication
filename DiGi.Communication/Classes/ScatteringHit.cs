using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class ScatteringHit : SerializableObject, IScatteringHit
    {
        [JsonInclude, JsonPropertyName(nameof(ElectricalProperties))]
        private readonly ElectricalProperties? electricalProperties;

        [JsonInclude, JsonPropertyName(nameof(Frequency))]
        private readonly double frequency;

        [JsonInclude, JsonPropertyName(nameof(Location_Receiver))]
        private readonly Point3D? location_Receiver;

        [JsonInclude, JsonPropertyName(nameof(Location_Transmitter))]
        private readonly Point3D? location_Transmitter;

        [JsonInclude, JsonPropertyName(nameof(Location))]
        private readonly Point3D? location;
        
        [JsonInclude, JsonPropertyName(nameof(Reference))]
        private readonly string? reference;

        public ScatteringHit(string? reference, ElectricalProperties? electricalProperties, double frequency, Point3D? location_Transmitter, Point3D? location_Receiver, Point3D? location)
            : base()
        {
            this.reference = reference;
            this.electricalProperties = Core.Query.Clone(electricalProperties);
            this.frequency = frequency;
            this.location_Transmitter = Core.Query.Clone(location_Transmitter);
            this.location_Receiver = Core.Query.Clone(location_Receiver);
            this.location = Core.Query.Clone(location);
        }

        public ScatteringHit(ScatteringHit? scatteringHit)
            : base(scatteringHit)
        {
            if (scatteringHit != null)
            {
                reference = scatteringHit.reference;
                frequency = scatteringHit.frequency;
                location = scatteringHit.Location;
                location_Transmitter = scatteringHit.Location_Transmitter;
                location_Receiver = scatteringHit.Location_Receiver;
                electricalProperties = scatteringHit.ElectricalProperties;

            }
        }

        public ScatteringHit(JsonObject? jsonObject)
            : base(jsonObject)
        {
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
        /// Gets the 3D location of the hit point.
        /// </summary>
        [JsonIgnore]
        public Point3D? Location
        {
            get
            {
                return Core.Query.Clone(location);
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
        /// Calculates the azimuth angle in radians for the specified node function using the hit location.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <returns>The azimuth angle in radians [0, 2π), or <see cref="double.NaN"/> if invalid.</returns>
        public double GetAzimuth(Function function)
        {
            return GetAzimuth(function, location);
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
        /// Calculates the elevation angle in radians for the specified node function using the hit location.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <returns>The elevation angle in radians [0, π], or <see cref="double.NaN"/> if invalid.</returns>
        public double GetElevation(Function function)
        {
            return GetElevation(function, location);
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
        /// Gets the ray in 3D space associated with the specified node function using the hit location.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <returns>The 3D ray, or <see langword="null"/> if invalid.</returns>
        public Ray3D? GetRay3D(Function function)
        {
            return GetRay3D(function, location);
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
        /// Gets the unit direction vector associated with the specified node function using the hit location.
        /// </summary>
        /// <param name="function">The node function (Transmitter or Receiver).</param>
        /// <returns>The unit direction vector, or <see langword="null"/> if invalid.</returns>
        public Vector3D? GetVector3D(Function function)
        {
            return GetVector3D(function, location);
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

        /// <summary>
        /// Calculates the material conductivity in Siemens per meter [S/m] at the operating frequency.
        /// </summary>
        /// <returns>The conductivity [S/m], or <see cref="double.NaN"/> if electrical properties are missing.</returns>
        public double GetConductivity()
        {
            if (electricalProperties is null)
            {
                return double.NaN;
            }

            return electricalProperties.GetConductivity(frequency);
        }

        /// <summary>
        /// Calculates the material relative permittivity (dielectric constant) at the operating frequency.
        /// </summary>
        /// <returns>The relative permittivity, or <see cref="double.NaN"/> if electrical properties are missing.</returns>
        public double GetRelativePermittivity()
        {
            if (electricalProperties is null)
            {
                return double.NaN;
            }

            return electricalProperties.GetRelativePermittivity(frequency);
        }

        /// <summary>
        /// Gets the surface normal unit vector at the hit point derived from specular reflection geometry.
        /// </summary>
        /// <returns>The unit surface normal vector, or <see langword="null"/> if invalid.</returns>
        public Vector3D? GetNormal()
        {
            Vector3D? vector3D_Transmitter = GetVector3D(Function.Transmitter);
            if (vector3D_Transmitter is null)
            {
                return null;
            }

            Vector3D? vector3D_Receiver = GetVector3D(Function.Receiver);
            if (vector3D_Receiver is null)
            {
                return null;
            }

            return (vector3D_Receiver.Unit + vector3D_Transmitter.GetInversed().Unit)?.Unit;
        }

        /// <summary>
        /// Calculates the reflection angle (angle of incidence) in radians relative to the surface normal vector.
        /// </summary>
        /// <remarks>
        /// According to standard scientific radioscience definitions (ITU-R P.2040, IEEE Std 211), the reflection angle
        /// is the angle between the ray direction and the surface normal vector (0 rad = normal incidence, π/2 rad = parallel to surface).
        /// </remarks>
        /// <returns>The reflection angle in radians [0, π/2], or <see cref="double.NaN"/> if invalid.</returns>
        public double GetReflectionAngle()
        {
            Vector3D? vector3D_Receiver = GetVector3D(Function.Receiver);
            if (vector3D_Receiver is null)
            {
                return double.NaN;
            }

            Vector3D? vector3D_Normal = GetNormal();
            if (vector3D_Normal is null)
            {
                return double.NaN;
            }

            return vector3D_Receiver.Angle(vector3D_Normal);
        }

        /// <summary>
        /// Calculates the grazing angle in radians relative to the surface tangent plane.
        /// </summary>
        /// <remarks>
        /// The grazing angle is defined as (π/2 - ReflectionAngle), measuring elevation above the reflecting surface plane (0 rad = parallel to surface, π/2 rad = normal incidence).
        /// </remarks>
        /// <returns>The grazing angle in radians [0, π/2], or <see cref="double.NaN"/> if invalid.</returns>
        public double GetGrazingAngle()
        {
            double reflectionAngle = GetReflectionAngle();
            if (double.IsNaN(reflectionAngle))
            {
                return double.NaN;
            }

            return (Math.PI / 2) - reflectionAngle;
        }

        /// <summary>
        /// Calculates the complex reflection coefficient for vertical polarization at the hit point.
        /// <para>The relative complex electrical permittivity is evaluated as epsilon_k' = epsilon_wk - j * 60 * lambda * sigma_k, where lambda is the wavelength in meters [m].</para>
        /// <para>The coefficient is then Gamma_kl = (epsilon_k' * sin(gamma_kl) - sqrt(epsilon_k' - cos^2(gamma_kl))) / (epsilon_k' * sin(gamma_kl) + sqrt(epsilon_k' - cos^2(gamma_kl))).</para>
        /// </summary>
        /// <remarks>
        /// The angle gamma_kl is measured from the reflecting surface plane, therefore the grazing angle returned by <see cref="GetGrazingAngle"/> is used, not the reflection angle relative to the surface normal.
        /// </remarks>
        /// <returns>The complex reflection coefficient for vertical polarization, or a <see cref="Complex"/> with <see cref="double.NaN"/> components if invalid.</returns>
        public Complex GetVerticalPolarizationReflection()
        {
            Complex complex_Invalid = new(double.NaN, double.NaN);

            if (double.IsNaN(frequency) || double.IsInfinity(frequency) || frequency <= 0)
            {
                return complex_Invalid;
            }

            double relativePermittivity = GetRelativePermittivity();
            if (double.IsNaN(relativePermittivity))
            {
                return complex_Invalid;
            }

            double conductivity = GetConductivity();
            if (double.IsNaN(conductivity))
            {
                return complex_Invalid;
            }

            double grazingAngle = GetGrazingAngle();
            if (double.IsNaN(grazingAngle))
            {
                return complex_Invalid;
            }

            // 1. Convert frequency from Hz to MHz to match the provided propagation formula.
            double frequencyMHz = frequency / 1_000_000.0;

            // 2. Calculate wavelength (lambda) in meters.
            double wavelength = 300.0 / frequencyMHz;

            // 3. Calculate relative complex electrical permittivity (epsilon_k').
            // The formula is: epsilon_k' = epsilon_wk - j * 60 * lambda * sigma_k
            double imaginaryPart = -60.0 * wavelength * conductivity;
            Complex complexPermittivity = new(relativePermittivity, imaginaryPart);

            // 4. Calculate trigonometric values for the grazing angle (gamma).
            double sinGamma = Math.Sin(grazingAngle);
            double cosGamma = Math.Cos(grazingAngle);

            // 5. Calculate the first main term: epsilon_k' * sin(gamma)
            Complex complex_1 = complexPermittivity * sinGamma;

            // 6. Calculate the second main term: sqrt(epsilon_k' - cos^2(gamma))
            Complex complex_2 = Complex.Sqrt(complexPermittivity - (cosGamma * cosGamma));

            // 7. Calculate final vertical polarization reflection coefficient (Gamma_kl).
            // The formula is: (complex_1 - complex_2) / (complex_1 + complex_2)
            return (complex_1 - complex_2) / (complex_1 + complex_2);
        }
    }
}
