using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents the frequency-dependent electrical properties of a material, including permittivity and conductivity parameters.
    /// </summary>
    public class ElectricalProperties : SerializableObject, ICommunicationSerializableObject, INamedObject, System.IEquatable<ElectricalProperties>
    {
        [JsonInclude, JsonPropertyName(nameof(A))]
        private readonly double a;

        [JsonInclude, JsonPropertyName(nameof(B))]
        private readonly double b;

        [JsonInclude, JsonPropertyName(nameof(C))]
        private readonly double c;

        [JsonInclude, JsonPropertyName(nameof(D))]
        private readonly double d;

        [JsonInclude, JsonPropertyName(nameof(FrequencyRange))]
        private readonly Range<double>? frequencyRange;

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricalProperties"/> class with the specified parameters.
        /// </summary>
        /// <param name="name">The name of the material.</param>
        /// <param name="a">The relative permittivity coefficient a.</param>
        /// <param name="b">The relative permittivity exponent b.</param>
        /// <param name="c">The conductivity coefficient c.</param>
        /// <param name="d">The conductivity exponent d.</param>
        /// <param name="frequencyRange">The valid frequency range for these electrical properties.</param>
        public ElectricalProperties(string? name, double a, double b, double c, double d, Range<double>? frequencyRange)
            :base()
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.frequencyRange = Core.Query.Clone(frequencyRange);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricalProperties"/> class by copying another instance.
        /// </summary>
        /// <param name="electricalProperties">The instance to copy properties from.</param>
        public ElectricalProperties(ElectricalProperties electricalProperties)
            : base(electricalProperties)
        {
           if(electricalProperties is not null)
            {
                name = electricalProperties.Name;
                a = electricalProperties.a;
                b = electricalProperties.b;
                c = electricalProperties.c;
                d = electricalProperties.d;
                frequencyRange = Core.Query.Clone(electricalProperties.frequencyRange);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricalProperties"/> class from a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serialized property values.</param>
        public ElectricalProperties(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        /// <summary> Gets the relative permittivity coefficient a. </summary>
        [JsonIgnore]
        public double A
        {
            get
            {
                return a;
            }
        }

        /// <summary> Gets the relative permittivity exponent b. </summary>
        [JsonIgnore]
        public double B
        {
            get
            {
                return b;
            }
        }

        /// <summary> Gets the conductivity coefficient c. </summary>
        [JsonIgnore]
        public double C
        {
            get
            {
                return c;
            }
        }

        /// <summary> Gets the conductivity exponent d. </summary>
        [JsonIgnore]
        public double D
        {
            get
            {
                return d;
            }
        }

        /// <summary> Gets a clone of the frequency range for which these electrical properties are valid. </summary>
        [JsonIgnore]
        public Range<double>? FrequencyRange
        {
            get
            {
                return Core.Query.Clone(frequencyRange);
            }
        }

        /// <summary> Gets the name of the material. </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Determines whether two <see cref="ElectricalProperties"/> instances are not equal.
        /// </summary>
        /// <param name="electricalProperties_1">The first instance to compare.</param>
        /// <param name="electricalProperties_2">The second instance to compare.</param>
        /// <returns><see langword="true"/> if the instances are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(ElectricalProperties? electricalProperties_1, ElectricalProperties? electricalProperties_2)
        {
            return !(electricalProperties_1 == electricalProperties_2);
        }

        /// <summary>
        /// Determines whether two <see cref="ElectricalProperties"/> instances are equal.
        /// </summary>
        /// <param name="electricalProperties_1">The first instance to compare.</param>
        /// <param name="electricalProperties_2">The second instance to compare.</param>
        /// <returns><see langword="true"/> if the instances are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(ElectricalProperties? electricalProperties_1, ElectricalProperties? electricalProperties_2)
        {
            return Equals(electricalProperties_1, electricalProperties_2);
        }

        /// <summary>
        /// Indicates whether the current instance is equal to another <see cref="ElectricalProperties"/> instance.
        /// </summary>
        /// <param name="electricalProperties">An instance to compare with this instance.</param>
        /// <returns><see langword="true"/> if the current instance is equal to the <paramref name="electricalProperties"/> parameter; otherwise, <see langword="false"/>.</returns>
        public bool Equals(ElectricalProperties? electricalProperties)
        {
            if (electricalProperties is null)
            {
                return false;
            }

            if (ReferenceEquals(this, electricalProperties))
            {
                return true;
            }

            return string.Equals(name, electricalProperties.name, System.StringComparison.Ordinal) &&
                   EqualityComparer<double>.Default.Equals(a, electricalProperties.a) &&
                   EqualityComparer<double>.Default.Equals(b, electricalProperties.b) &&
                   EqualityComparer<double>.Default.Equals(c, electricalProperties.c) &&
                   EqualityComparer<double>.Default.Equals(d, electricalProperties.d) &&
                   Equals(frequencyRange, electricalProperties.frequencyRange);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns><see langword="true"/> if the specified object is equal to the current instance; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalProperties);
        }

        /// <summary>
        /// Electrical conductivity sigma_k of the object [S/m].
        /// </summary>
        /// <param name="frequency">Frequency in [Hz]</param>
        /// <returns>The electrical conductivity [S/m], or <see cref="double.NaN"/> if calculation inputs are invalid.</returns>
        public double GetConductivity(double frequency)
        {
            if (double.IsNaN(frequency) || double.IsNaN(c) || double.IsNaN(d))
            {
                return double.NaN;
            }

            return c * System.Math.Pow(frequency * 1e-9, d);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 31) + (name is null ? 0 : name.GetHashCode());
                hash = (hash * 31) + EqualityComparer<double>.Default.GetHashCode(a);
                hash = (hash * 31) + EqualityComparer<double>.Default.GetHashCode(b);
                hash = (hash * 31) + EqualityComparer<double>.Default.GetHashCode(c);
                hash = (hash * 31) + EqualityComparer<double>.Default.GetHashCode(d);
                hash = (hash * 31) + (frequencyRange is null ? 0 : frequencyRange.GetHashCode());
                return hash;
            }
        }

        /// <summary>
        /// Relative electrical permittivity epsilon_wk of the object [-].
        /// </summary>
        /// <param name="frequency">Frequency in [Hz]</param>
        /// <returns>The relative electrical permittivity [-], or <see cref="double.NaN"/> if calculation inputs are invalid.</returns>
        public double GetRelativePermittivity(double frequency)
        {
            if(double.IsNaN(frequency) || double.IsNaN(a) || double.IsNaN(b))
            {
                return double.NaN;
            }

            return a * System.Math.Pow(frequency * 1e-9, b);
        }
    }
}
