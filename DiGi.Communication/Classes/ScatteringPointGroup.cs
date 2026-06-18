using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a group of scattering points, associating a unique reference identifier with a collection of 3D point coordinates for serialization and communication purposes.
    /// </summary>
    public class ScatteringPointGroup : SerializableObject, ICommunicationSerializableObject
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference;

        [JsonInclude, JsonPropertyName("Points")]
        private readonly List<Point3D>? points;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringPointGroup"/> class.
        /// </summary>
        /// <param name="reference">The reference identifier for the scattering point group.</param>
        /// <param name="points">A collection of 3D points to be included in the group.</param>
        public ScatteringPointGroup(string? reference, IEnumerable<Point3D>? points)
            : base()
        {
            this.points = Core.Query.CloneAndFilterNulls(points);
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringPointGroup"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the current instance.</param>
        public ScatteringPointGroup(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringPointGroup"/> class by copying another instance.
        /// </summary>
        /// <param name="scatteringPointGroup">The source <see cref="ScatteringPointGroup"/> object to copy from, or null to create an empty group.</param>
        public ScatteringPointGroup(ScatteringPointGroup? scatteringPointGroup)
            : base(scatteringPointGroup)
        {
            if (scatteringPointGroup != null)
            {
                points = Core.Query.CloneAndFilterNulls(scatteringPointGroup.points);
                reference = scatteringPointGroup.Reference;
            }
        }

        /// <summary> Gets the serializable reference object. </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }

        /// <summary> Gets the collection of points in three-dimensional space associated with this scattering point group, filtered to remove null entries. </summary>
        [JsonIgnore]
        public List<Point3D>? Points
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(points);
            }
        }
    }
}
