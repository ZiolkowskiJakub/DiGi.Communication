using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a group of scattering objects identified by a bounding box and a reference string.
    /// </summary>
    public class ScatteringGroup : GuidObject, IScatteringGroup
    {
        [JsonInclude, JsonPropertyName("BoundingBox3D")]
        private readonly BoundingBox3D? boundingBox3D;

        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringGroup"/> class with the specified unique identifier, reference, and bounding box.
        /// </summary>
        /// <param name="guid">The unique identifier for the scattering group.</param>
        /// <param name="reference">The reference string for the scattering group. If null or whitespace, the GUID string is used.</param>
        /// <param name="boundingBox3D">The 3D bounding box that encloses the scattering group.</param>
        public ScatteringGroup(Guid guid, string? reference, BoundingBox3D? boundingBox3D)
            : base(guid)
        {
            this.reference = string.IsNullOrWhiteSpace(reference) ? guid.ToString() : reference;
            this.boundingBox3D = Core.Query.Clone(boundingBox3D);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringGroup"/> class with the specified reference and bounding box, generating a new unique identifier.
        /// </summary>
        /// <param name="reference">The reference string for the scattering group. If null or whitespace, the generated GUID string is used.</param>
        /// <param name="boundingBox3D">The 3D bounding box that encloses the scattering group.</param>
        public ScatteringGroup(string? reference, BoundingBox3D? boundingBox3D)
            : base()
        {
            this.reference = string.IsNullOrWhiteSpace(reference) ? Guid.ToString() : reference;
            this.boundingBox3D = Core.Query.Clone(boundingBox3D);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringGroup"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data for the scattering group.</param>
        public ScatteringGroup(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringGroup"/> class by copying an existing scattering group.
        /// </summary>
        /// <param name="scatteringGroup">The source scattering group to copy from, or <see langword="null"/> to create a default instance.</param>
        public ScatteringGroup(ScatteringGroup? scatteringGroup)
            : base(scatteringGroup)
        {
            if (scatteringGroup != null)
            {
                reference = scatteringGroup.reference;
                boundingBox3D = Core.Query.Clone(scatteringGroup.boundingBox3D);
            }
        }

        /// <summary>
        /// Gets the 3D bounding box that encloses the scattering group.
        /// </summary>
        [JsonIgnore]
        public BoundingBox3D? BoundingBox3D
        {
            get
            {
                return Core.Query.Clone(boundingBox3D);
            }
        }

        /// <summary>
        /// Gets the reference identifier of the scattering group.
        /// </summary>
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