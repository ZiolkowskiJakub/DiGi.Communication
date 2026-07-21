using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents an object that can be scattered within a scene, containing data such as the associated 3D mesh, a reference identifier, relative permittivity, and electrical conductivity.
    /// </summary>
    public class ScatteringObject : GuidObject, IScatteringObject
    {
        [JsonInclude, JsonPropertyName(nameof(Mesh3D))]
        private readonly Mesh3D? mesh3D;

        [JsonInclude, JsonPropertyName(nameof(Reference))]
        private readonly string? reference;

        [JsonInclude, JsonPropertyName(nameof(RelativePermittivity))]
        private readonly double relativePermittivity = 1.0;

        [JsonInclude, JsonPropertyName(nameof(ElectricalConductivity))]
        private readonly double electricalConductivity = 0.0;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringObject"/> class.
        /// </summary>
        /// <param name="guid">The unique identifier for the scattering object.</param>
        /// <param name="reference">An optional reference string; if null or whitespace, the GUID is used as the reference.</param>
        /// <param name="mesh3D">The three-dimensional mesh associated with this scattering object.</param>
        /// <param name="relativePermittivity">The relative permittivity of the object. Defaults to 1.0.</param>
        /// <param name="electricalConductivity">The electrical conductivity of the object. Defaults to 0.0.</param>
        public ScatteringObject(Guid guid, string? reference, Mesh3D? mesh3D, double relativePermittivity = 1.0, double electricalConductivity = 0.0)
            : base(guid)
        {
            this.reference = string.IsNullOrWhiteSpace(reference) ? guid.ToString() : reference;
            this.mesh3D = Core.Query.Clone(mesh3D);
            this.relativePermittivity = relativePermittivity;
            this.electricalConductivity = electricalConductivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringObject"/> class.
        /// </summary>
        /// <param name="reference">The reference identifier for the scattering object. If null or whitespace, the unique identifier (Guid) is used instead.</param>
        /// <param name="mesh3D">The three-dimensional mesh associated with the scattering object.</param>
        /// <param name="relativePermittivity">The relative permittivity of the object. Defaults to 1.0.</param>
        /// <param name="electricalConductivity">The electrical conductivity of the object. Defaults to 0.0.</param>
        public ScatteringObject(string? reference, Mesh3D? mesh3D, double relativePermittivity = 1.0, double electricalConductivity = 0.0)
            : base()
        {
            this.reference = string.IsNullOrWhiteSpace(reference) ? Guid.ToString() : reference;
            this.mesh3D = Core.Query.Clone(mesh3D);
            this.relativePermittivity = relativePermittivity;
            this.electricalConductivity = electricalConductivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringObject"/> class by copying the properties of another <see cref="ScatteringObject"/>.
        /// </summary>
        /// <param name="scatteringObject">The source scattering object to copy from, or <see langword="null"/> to initialize a new instance without existing data.</param>
        public ScatteringObject(ScatteringObject? scatteringObject)
            : base(scatteringObject)
        {
            if (scatteringObject != null)
            {
                reference = scatteringObject.reference;
                mesh3D = Core.Query.Clone(scatteringObject.mesh3D);
                relativePermittivity = scatteringObject.relativePermittivity;
                electricalConductivity = scatteringObject.electricalConductivity;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringObject"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the current instance.</param>
        public ScatteringObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
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

        /// <summary> Gets a clone of the three-dimensional mesh associated with this scattering object. </summary>
        [JsonIgnore]
        public Mesh3D? Mesh3D
        {
            get
            {
                return Core.Query.Clone(mesh3D);
            }
        }

        /// <summary> 
        /// Gets the relative permittivity of the object. [-] 
        /// </summary>
        [JsonIgnore]
        public double RelativePermittivity
        {
            get
            {
                return relativePermittivity;
            }
        }

        /// <summary> 
        /// Gets the electrical conductivity of the object. [S/m]
        /// </summary>
        [JsonIgnore]
        public double ElectricalConductivity
        {
            get
            {
                return electricalConductivity;
            }
        }
    }
}