using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Obselete.Classes
{
    /// <summary>
    /// Triangular spatial cell of the scattering object mesh. Coordinates are expressed in the model coordinate system: the transmitter is placed at the origin, the transmitter-receiver direction determines the OX axis and the earth surface forms the XOY plane.
    /// </summary>
    public class MeshCell : SerializableObject, ICommunicationSerializableObject
    {
        /// <summary>
        /// Center of gravity of the triangular cell [m].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Center))]
        private readonly Point3D? center;

        /// <summary>
        /// Electrical material properties of the cell.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(MaterialProperties))]
        private readonly MaterialProperties? materialProperties;

        /// <summary>
        /// Normal vector of the cell plane.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Normal))]
        private readonly Vector3D? normal;

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshCell"/> class.
        /// </summary>
        /// <param name="center">Center of gravity of the triangular cell [m].</param>
        /// <param name="normal">Normal vector of the cell plane.</param>
        /// <param name="materialProperties">Electrical material properties of the cell.</param>
        public MeshCell(Point3D? center, Vector3D? normal, MaterialProperties? materialProperties)
        {
            this.center = Core.Query.Clone(center);
            this.normal = Core.Query.Clone(normal);
            this.materialProperties = Core.Query.Clone(materialProperties);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshCell"/> class by copying another mesh cell.
        /// </summary>
        /// <param name="meshCell">The source mesh cell to copy from.</param>
        public MeshCell(MeshCell? meshCell)
            : base(meshCell)
        {
            if (meshCell != null)
            {
                center = Core.Query.Clone(meshCell.center);
                normal = Core.Query.Clone(meshCell.normal);
                materialProperties = Core.Query.Clone(meshCell.materialProperties);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshCell"/> class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data.</param>
        public MeshCell(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Center of gravity of the triangular cell [m].
        /// </summary>
        [JsonIgnore]
        public Point3D? Center
        {
            get
            {
                return Core.Query.Clone(center);
            }
        }

        /// <summary>
        /// Electrical material properties of the cell.
        /// </summary>
        [JsonIgnore]
        public MaterialProperties? MaterialProperties
        {
            get
            {
                return Core.Query.Clone(materialProperties);
            }
        }

        /// <summary>
        /// Normal vector of the cell plane.
        /// </summary>
        [JsonIgnore]
        public Vector3D? Normal
        {
            get
            {
                return Core.Query.Clone(normal);
            }
        }
    }
}