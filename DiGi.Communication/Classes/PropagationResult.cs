using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Result of the comparative multi-ellipsoidal propagation analysis.
    /// </summary>
    public class PropagationResult : SerializableObject, ICommunicationSerializableObject
    {
        /// <summary>
        /// Total normalized power P_0 reaching the receiving antenna after applying the directional reception characteristic [-]. The final result of the comparative analysis.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(DirectionalPower))]
        private readonly double directionalPower;

        /// <summary>
        /// Ellipsoid components P_n determined for the individual delays of the Power Delay Profile.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(EllipsoidComponents))]
        private readonly List<EllipsoidComponent>? ellipsoidComponents;

        /// <summary>
        /// Rays arriving at the receiving antenna: arrival directions (theta_kl, phi_kl) with their assigned corrected powers p_nkl. The powers sum to 1 for a normalized Power Delay Profile.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Rays))]
        private readonly List<ArrivalRay>? rays;

        /// <summary>
        /// Total received power P before applying the directional antenna characteristics [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(TotalPower))]
        private readonly double totalPower;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropagationResult"/> class.
        /// </summary>
        /// <param name="directionalPower">Total normalized power P_0 reaching the receiving antenna after applying the directional reception characteristic [-]. The final result of the comparative analysis.</param>
        /// <param name="ellipsoidComponents">Ellipsoid components P_n determined for the individual delays of the Power Delay Profile.</param>
        /// <param name="rays">Rays arriving at the receiving antenna: arrival directions (theta_kl, phi_kl) with their assigned corrected powers p_nkl.</param>
        /// <param name="totalPower">Total received power P before applying the directional antenna characteristics [-].</param>
        public PropagationResult(double directionalPower, IEnumerable<EllipsoidComponent>? ellipsoidComponents, IEnumerable<ArrivalRay>? rays, double totalPower)
        {
            this.directionalPower = directionalPower;
            this.ellipsoidComponents = Core.Query.CloneAndFilterNulls(ellipsoidComponents);
            this.rays = Core.Query.CloneAndFilterNulls(rays);
            this.totalPower = totalPower;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropagationResult"/> class by copying another propagation result.
        /// </summary>
        /// <param name="propagationResult">The source propagation result to copy from.</param>
        public PropagationResult(PropagationResult? propagationResult)
            : base(propagationResult)
        {
            if (propagationResult != null)
            {
                directionalPower = propagationResult.directionalPower;
                ellipsoidComponents = Core.Query.CloneAndFilterNulls(propagationResult.ellipsoidComponents);
                rays = Core.Query.CloneAndFilterNulls(propagationResult.rays);
                totalPower = propagationResult.totalPower;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropagationResult"/> class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data.</param>
        public PropagationResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Total normalized power P_0 reaching the receiving antenna after applying the directional reception characteristic [-]. The final result of the comparative analysis.
        /// </summary>
        [JsonIgnore]
        public double DirectionalPower
        {
            get
            {
                return directionalPower;
            }
        }

        /// <summary>
        /// Ellipsoid components P_n determined for the individual delays of the Power Delay Profile.
        /// </summary>
        [JsonIgnore]
        public List<EllipsoidComponent>? EllipsoidComponents
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(ellipsoidComponents);
            }
        }

        /// <summary>
        /// Rays arriving at the receiving antenna: arrival directions (theta_kl, phi_kl) with their assigned corrected powers p_nkl. The powers sum to 1 for a normalized Power Delay Profile.
        /// </summary>
        [JsonIgnore]
        public List<ArrivalRay>? Rays
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(rays);
            }
        }

        /// <summary>
        /// Total received power P before applying the directional antenna characteristics [-].
        /// </summary>
        [JsonIgnore]
        public double TotalPower
        {
            get
            {
                return totalPower;
            }
        }
    }
}