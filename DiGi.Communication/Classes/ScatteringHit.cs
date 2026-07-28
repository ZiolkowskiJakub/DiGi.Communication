using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a hit result containing a reference identifier to a scattering object and the 3D ray.
    /// </summary>
    public class ScatteringHit : SerializableObject, IScatteringHit
    {
        [JsonInclude, JsonPropertyName(nameof(Ray3D))]
        private readonly Ray3D? ray3D;

        [JsonInclude, JsonPropertyName(nameof(Reference))]
        private readonly string? reference;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringHit"/> class with the specified reference and ray.
        /// </summary>
        /// <param name="reference">The reference identifier of the target scattering object.</param>
        /// <param name="ray3D">The ray in three-dimensional space associated with the hit.</param>
        public ScatteringHit(string? reference, Ray3D? ray3D)
            : base()
        {
            this.reference = reference;
            this.ray3D = Core.Query.Clone(ray3D);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringHit"/> class from a <see cref="IScatteringObject"/> instance and ray.
        /// </summary>
        /// <param name="scatteringObject">The scattering object hit by the ray.</param>
        /// <param name="ray3D">The ray in three-dimensional space associated with the hit.</param>
        public ScatteringHit(IScatteringObject? scatteringObject, Ray3D? ray3D)
            : this(scatteringObject?.Reference, ray3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringHit"/> class by copying another <see cref="ScatteringHit"/> instance.
        /// </summary>
        /// <param name="scatteringHit">The source hit instance to copy from, or <see langword="null"/> to create a default instance.</param>
        public ScatteringHit(ScatteringHit? scatteringHit)
            : base(scatteringHit)
        {
            if (scatteringHit != null)
            {
                reference = scatteringHit.reference;
                ray3D = Core.Query.Clone(scatteringHit.ray3D);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringHit"/> class from a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serialized property values.</param>
        public ScatteringHit(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary> Gets a clone of the ray in three-dimensional space associated with the hit. </summary>
        [JsonIgnore]
        public Ray3D? Ray3D
        {
            get
            {
                return Core.Query.Clone(ray3D);
            }
        }

        /// <summary> Gets the reference identifier of the hit scattering object. </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }
    }
}
