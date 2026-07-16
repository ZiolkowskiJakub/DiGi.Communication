using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Obselete.Classes
{
    /// <summary>
    /// Power component P_n of a single propagation ellipsoid related to the delay tau_n of the Power Delay Profile.
    /// </summary>
    public class EllipsoidComponent : SerializableObject, ICommunicationSerializableObject
    {
        /// <summary>
        /// Delay tau_n [s] related to the ellipsoid.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Delay))]
        private readonly double delay;

        /// <summary>
        /// Normalized power p_n = P_n / P resulting from the model [-]. Calculated in Stage II.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(FractionalPower))]
        private readonly double fractionalPower;

        /// <summary>
        /// Correction coefficient w_0n = p'_n / p_n for ray scattering object mapping errors [-]. Calculated in Stage II.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(MappingErrorCorrectionCoefficient))]
        private readonly double mappingErrorCorrectionCoefficient;

        /// <summary>
        /// Normalized (fractional) power p'_n retrieved directly from the measured Power Delay Profile [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(MeasuredFractionalPower))]
        private readonly double measuredFractionalPower;

        /// <summary>
        /// Component power P_n = |Gamma_n|^2 [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Power))]
        private readonly double power;

        /// <summary>
        /// Power equivalence coefficient w_Pn = P_n / P'_n [-]. Calculated in Stage II.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(PowerEquivalenceCoefficient))]
        private readonly double powerEquivalenceCoefficient;

        /// <summary>
        /// Contributions of the mesh cells assigned to the ellipsoid.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(RayContributions))]
        private readonly List<RayContribution>? rayContributions;

        /// <summary>
        /// Reference power P'_n: sum of squared moduli of the weighted reflection coefficients [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(ReferencePower))]
        private readonly double referencePower;

        /// <summary>
        /// Sum Gamma_n of the weighted complex reflection coefficients of the whole ellipsoid [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(ReflectionCoefficientSum))]
        private readonly Complex reflectionCoefficientSum;

        /// <summary>
        /// Semi-major axis a_n of the ellipsoid [m].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(SemiMajorAxis))]
        private readonly double semiMajorAxis;

        /// <summary>
        /// Semi-minor axes b_n = c_n of the ellipsoid [m].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(SemiMinorAxis))]
        private readonly double semiMinorAxis;

        /// <summary>
        /// Initializes a new instance of the <see cref="EllipsoidComponent"/> class.
        /// </summary>
        /// <param name="delay">Delay tau_n [s] related to the ellipsoid.</param>
        /// <param name="fractionalPower">Normalized power p_n = P_n / P resulting from the model [-]. Calculated in Stage II.</param>
        /// <param name="mappingErrorCorrectionCoefficient">Correction coefficient w_0n = p'_n / p_n for ray scattering object mapping errors [-]. Calculated in Stage II.</param>
        /// <param name="measuredFractionalPower">Normalized (fractional) power p'_n retrieved directly from the measured Power Delay Profile [-].</param>
        /// <param name="power">Component power P_n = |Gamma_n|^2 [-].</param>
        /// <param name="powerEquivalenceCoefficient">Power equivalence coefficient w_Pn = P_n / P'_n [-]. Calculated in Stage II.</param>
        /// <param name="rayContributions">Contributions of the mesh cells assigned to the ellipsoid.</param>
        /// <param name="referencePower">Reference power P'_n: sum of squared moduli of the weighted reflection coefficients [-].</param>
        /// <param name="reflectionCoefficientSum">Sum Gamma_n of the weighted complex reflection coefficients of the whole ellipsoid [-].</param>
        /// <param name="semiMajorAxis">Semi-major axis a_n of the ellipsoid [m].</param>
        /// <param name="semiMinorAxis">Semi-minor axes b_n = c_n of the ellipsoid [m].</param>
        public EllipsoidComponent(double delay, double fractionalPower, double mappingErrorCorrectionCoefficient, double measuredFractionalPower, double power, double powerEquivalenceCoefficient, IEnumerable<RayContribution>? rayContributions, double referencePower, Complex reflectionCoefficientSum, double semiMajorAxis, double semiMinorAxis)
        {
            this.delay = delay;
            this.fractionalPower = fractionalPower;
            this.mappingErrorCorrectionCoefficient = mappingErrorCorrectionCoefficient;
            this.measuredFractionalPower = measuredFractionalPower;
            this.power = power;
            this.powerEquivalenceCoefficient = powerEquivalenceCoefficient;
            this.rayContributions = Core.Query.CloneAndFilterNulls(rayContributions);
            this.referencePower = referencePower;
            this.reflectionCoefficientSum = reflectionCoefficientSum;
            this.semiMajorAxis = semiMajorAxis;
            this.semiMinorAxis = semiMinorAxis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EllipsoidComponent"/> class by copying another ellipsoid component.
        /// </summary>
        /// <param name="ellipsoidComponent">The source ellipsoid component to copy from.</param>
        public EllipsoidComponent(EllipsoidComponent? ellipsoidComponent)
            : base(ellipsoidComponent)
        {
            if (ellipsoidComponent != null)
            {
                delay = ellipsoidComponent.delay;
                fractionalPower = ellipsoidComponent.fractionalPower;
                mappingErrorCorrectionCoefficient = ellipsoidComponent.mappingErrorCorrectionCoefficient;
                measuredFractionalPower = ellipsoidComponent.measuredFractionalPower;
                power = ellipsoidComponent.power;
                powerEquivalenceCoefficient = ellipsoidComponent.powerEquivalenceCoefficient;
                rayContributions = Core.Query.CloneAndFilterNulls(ellipsoidComponent.rayContributions);
                referencePower = ellipsoidComponent.referencePower;
                reflectionCoefficientSum = ellipsoidComponent.reflectionCoefficientSum;
                semiMajorAxis = ellipsoidComponent.semiMajorAxis;
                semiMinorAxis = ellipsoidComponent.semiMinorAxis;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EllipsoidComponent"/> class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data.</param>
        public EllipsoidComponent(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Delay tau_n [s] related to the ellipsoid.
        /// </summary>
        [JsonIgnore]
        public double Delay
        {
            get
            {
                return delay;
            }
        }

        /// <summary>
        /// Normalized power p_n = P_n / P resulting from the model [-]. Calculated in Stage II.
        /// </summary>
        [JsonIgnore]
        public double FractionalPower
        {
            get
            {
                return fractionalPower;
            }
        }

        /// <summary>
        /// Correction coefficient w_0n = p'_n / p_n for ray scattering object mapping errors [-]. Calculated in Stage II.
        /// </summary>
        [JsonIgnore]
        public double MappingErrorCorrectionCoefficient
        {
            get
            {
                return mappingErrorCorrectionCoefficient;
            }
        }

        /// <summary>
        /// Normalized (fractional) power p'_n retrieved directly from the measured Power Delay Profile [-].
        /// </summary>
        [JsonIgnore]
        public double MeasuredFractionalPower
        {
            get
            {
                return measuredFractionalPower;
            }
        }

        /// <summary>
        /// Component power P_n = |Gamma_n|^2 [-].
        /// </summary>
        [JsonIgnore]
        public double Power
        {
            get
            {
                return power;
            }
        }

        /// <summary>
        /// Power equivalence coefficient w_Pn = P_n / P'_n [-]. Calculated in Stage II.
        /// </summary>
        [JsonIgnore]
        public double PowerEquivalenceCoefficient
        {
            get
            {
                return powerEquivalenceCoefficient;
            }
        }

        /// <summary>
        /// Contributions of the mesh cells assigned to the ellipsoid.
        /// </summary>
        [JsonIgnore]
        public List<RayContribution>? RayContributions
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(rayContributions);
            }
        }

        /// <summary>
        /// Reference power P'_n: sum of squared moduli of the weighted reflection coefficients [-].
        /// </summary>
        [JsonIgnore]
        public double ReferencePower
        {
            get
            {
                return referencePower;
            }
        }

        /// <summary>
        /// Sum Gamma_n of the weighted complex reflection coefficients of the whole ellipsoid [-].
        /// </summary>
        [JsonIgnore]
        public Complex ReflectionCoefficientSum
        {
            get
            {
                return reflectionCoefficientSum;
            }
        }

        /// <summary>
        /// Semi-major axis a_n of the ellipsoid [m].
        /// </summary>
        [JsonIgnore]
        public double SemiMajorAxis
        {
            get
            {
                return semiMajorAxis;
            }
        }

        /// <summary>
        /// Semi-minor axes b_n = c_n of the ellipsoid [m].
        /// </summary>
        [JsonIgnore]
        public double SemiMinorAxis
        {
            get
            {
                return semiMinorAxis;
            }
        }
    }
}