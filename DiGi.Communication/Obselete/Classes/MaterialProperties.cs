using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Obselete.Classes
{
    /// <summary>
    /// Electrical material properties of a scattering object.
    /// </summary>
    public class MaterialProperties : SerializableObject, ICommunicationSerializableObject
    {
        /// <summary>
        /// Electrical conductivity sigma_k of the object [S/m].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Conductivity))]
        private readonly double conductivity;

        /// <summary>
        /// Relative electrical permittivity epsilon_wk of the object [-].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(RelativePermittivity))]
        private readonly double relativePermittivity;

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialProperties"/> class.
        /// </summary>
        /// <param name="relativePermittivity">Relative electrical permittivity of the object [-].</param>
        /// <param name="conductivity">Electrical conductivity of the object [S/m].</param>
        public MaterialProperties(double relativePermittivity, double conductivity)
        {
            this.relativePermittivity = relativePermittivity;
            this.conductivity = conductivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialProperties"/> class by copying another material properties instance.
        /// </summary>
        /// <param name="materialProperties">The source material properties to copy from.</param>
        public MaterialProperties(MaterialProperties? materialProperties)
            : base(materialProperties)
        {
            if (materialProperties != null)
            {
                relativePermittivity = materialProperties.relativePermittivity;
                conductivity = materialProperties.conductivity;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialProperties"/> class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data.</param>
        public MaterialProperties(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Electrical conductivity sigma_k of the object [S/m].
        /// </summary>
        [JsonIgnore]
        public double Conductivity
        {
            get
            {
                return conductivity;
            }
        }

        /// <summary>
        /// Relative electrical permittivity epsilon_wk of the object [-].
        /// </summary>
        [JsonIgnore]
        public double RelativePermittivity
        {
            get
            {
                return relativePermittivity;
            }
        }
    }
}