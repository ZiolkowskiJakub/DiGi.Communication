using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a geometric ray defined by an origin point and a direction vector, supporting serialization for communication purposes.
    /// </summary>
    public class Ray : SerializableObject, ICommunicationSerializableObject
    {
        [JsonInclude, JsonPropertyName("Point")]
        private readonly Point3D? point;

        [JsonInclude, JsonPropertyName("Vector")]
        private readonly Vector3D? vector;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ray"/> class with the specified starting point and direction vector.
        /// </summary>
        /// <param name="point">The starting point of the ray.</param>
        /// <param name="vector">The direction vector of the ray.</param>
        public Ray(Point3D? point, Vector3D? vector)
            : base()
        {
            this.point = Core.Query.Clone(point);
            this.vector = Core.Query.Clone(vector);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ray"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the current <see cref="Ray"/> instance.</param>
        public Ray(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ray"/> class by copying an existing <see cref="Ray"/> instance.
        /// </summary>
        /// <param name="ray">The source <see cref="Ray"/> instance to copy from, or <see langword="null"/>.</param>
        public Ray(Ray? ray)
            : base(ray)
        {
            if (ray != null)
            {
                point = Core.Query.Clone(ray.point);
                vector = Core.Query.Clone(ray.vector);
            }
        }

        /// <summary> Gets the point in three-dimensional space associated with this ray. </summary>
        [JsonIgnore]
        public Point3D? Point
        {
            get
            {
                return Core.Query.Clone(point);
            }
        }

        /// <summary> Gets the vector defining the segment. </summary>
        [JsonIgnore]
        public Vector3D? Vector
        {
            get
            {
                return Core.Query.Clone(vector);
            }
        }
    }
}