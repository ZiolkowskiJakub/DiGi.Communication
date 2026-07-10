using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Input data of the multi-ellipsoidal propagation model. The model coordinate system places the transmitter (Tx) at the origin, the receiver (Rx) at (Distance, 0, 0) — the Tx-Rx direction determines the OX axis — and the earth surface forms the XOY plane.
    /// </summary>
    public class PropagationModel : SerializableObject, ICommunicationSerializableObject
    {
        /// <summary>
        /// Distance d between the transmitter and receiver [m].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Distance))]
        private readonly double distance;

        /// <summary>
        /// Frequency f of the propagating electromagnetic wave [MHz].
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Frequency))]
        private readonly double frequency;

        /// <summary>
        /// Triangular spatial cells representing the scattering objects.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(MeshCells))]
        private readonly List<MeshCell>? meshCells;

        /// <summary>
        /// Polarization type of the propagating electromagnetic wave.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Polarization))]
        private readonly Polarization polarization;

        /// <summary>
        /// Normalized Power Delay Profile (PDP): delays tau_n mapped to the normalized (fractional) powers p'_n. The fractional powers are expected to sum to 1.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(SimpleMultipathPowerDelayProfile))]
        private readonly SimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile;

        /// <summary>
        /// Normalized reception characteristic g(theta, phi) of the directional receiving antenna. Not serializable: excluded from JSON persistence and cloning restores a <see langword="null"/> reference.
        /// </summary>
        private readonly AntennaCharacteristic? receivingDirectionalCharacteristic;

        /// <summary>
        /// Normalized reception characteristic g_0(theta, phi) of the omnidirectional receiving antenna. Not serializable: excluded from JSON persistence and cloning restores a <see langword="null"/> reference.
        /// </summary>
        private readonly AntennaCharacteristic? receivingOmnidirectionalCharacteristic;

        /// <summary>
        /// Normalized radiation characteristic g_T(theta, phi) of the directional transmitting antenna. Reserved for the transmitting-side comparison; not used by the receiving-side comparative analysis. Not serializable: excluded from JSON persistence and cloning restores a <see langword="null"/> reference.
        /// </summary>
        private readonly AntennaCharacteristic? transmittingDirectionalCharacteristic;

        /// <summary>
        /// Normalized radiation characteristic g_T0(theta, phi) of the omnidirectional transmitting antenna. Not serializable: excluded from JSON persistence and cloning restores a <see langword="null"/> reference.
        /// </summary>
        private readonly AntennaCharacteristic? transmittingOmnidirectionalCharacteristic;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropagationModel"/> class.
        /// </summary>
        /// <param name="distance">Distance d between the transmitter and receiver [m].</param>
        /// <param name="frequency">Frequency f of the propagating electromagnetic wave [MHz].</param>
        /// <param name="meshCells">Triangular spatial cells representing the scattering objects.</param>
        /// <param name="polarization">Polarization type of the propagating electromagnetic wave.</param>
        /// <param name="simpleMultipathPowerDelayProfile">Normalized Power Delay Profile (PDP): delays tau_n mapped to the normalized (fractional) powers p'_n.</param>
        /// <param name="receivingDirectionalCharacteristic">Normalized reception characteristic g(theta, phi) of the directional receiving antenna.</param>
        /// <param name="receivingOmnidirectionalCharacteristic">Normalized reception characteristic g_0(theta, phi) of the omnidirectional receiving antenna.</param>
        /// <param name="transmittingDirectionalCharacteristic">Normalized radiation characteristic g_T(theta, phi) of the directional transmitting antenna.</param>
        /// <param name="transmittingOmnidirectionalCharacteristic">Normalized radiation characteristic g_T0(theta, phi) of the omnidirectional transmitting antenna.</param>
        public PropagationModel(double distance, double frequency, IEnumerable<MeshCell>? meshCells, Polarization polarization, SimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile, AntennaCharacteristic? receivingDirectionalCharacteristic, AntennaCharacteristic? receivingOmnidirectionalCharacteristic, AntennaCharacteristic? transmittingDirectionalCharacteristic, AntennaCharacteristic? transmittingOmnidirectionalCharacteristic)
        {
            this.distance = distance;
            this.frequency = frequency;
            this.meshCells = Core.Query.CloneAndFilterNulls(meshCells);
            this.polarization = polarization;
            this.simpleMultipathPowerDelayProfile = Core.Query.Clone(simpleMultipathPowerDelayProfile);
            this.receivingDirectionalCharacteristic = receivingDirectionalCharacteristic;
            this.receivingOmnidirectionalCharacteristic = receivingOmnidirectionalCharacteristic;
            this.transmittingDirectionalCharacteristic = transmittingDirectionalCharacteristic;
            this.transmittingOmnidirectionalCharacteristic = transmittingOmnidirectionalCharacteristic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropagationModel"/> class by copying another propagation model.
        /// </summary>
        /// <param name="propagationModel">The source propagation model to copy from.</param>
        public PropagationModel(PropagationModel? propagationModel)
            : base(propagationModel)
        {
            if (propagationModel != null)
            {
                distance = propagationModel.distance;
                frequency = propagationModel.frequency;
                meshCells = Core.Query.CloneAndFilterNulls(propagationModel.meshCells);
                polarization = propagationModel.polarization;
                simpleMultipathPowerDelayProfile = Core.Query.Clone(propagationModel.simpleMultipathPowerDelayProfile);
                receivingDirectionalCharacteristic = propagationModel.receivingDirectionalCharacteristic;
                receivingOmnidirectionalCharacteristic = propagationModel.receivingOmnidirectionalCharacteristic;
                transmittingDirectionalCharacteristic = propagationModel.transmittingDirectionalCharacteristic;
                transmittingOmnidirectionalCharacteristic = propagationModel.transmittingOmnidirectionalCharacteristic;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropagationModel"/> class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data.</param>
        public PropagationModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Distance d between the transmitter and receiver [m].
        /// </summary>
        [JsonIgnore]
        public double Distance
        {
            get
            {
                return distance;
            }
        }

        /// <summary>
        /// Frequency f of the propagating electromagnetic wave [MHz].
        /// </summary>
        [JsonIgnore]
        public double Frequency
        {
            get
            {
                return frequency;
            }
        }

        /// <summary>
        /// Triangular spatial cells representing the scattering objects.
        /// </summary>
        [JsonIgnore]
        public List<MeshCell>? MeshCells
        {
            get
            {
                return Core.Query.CloneAndFilterNulls(meshCells);
            }
        }

        /// <summary>
        /// Polarization type of the propagating electromagnetic wave.
        /// </summary>
        [JsonIgnore]
        public Polarization Polarization
        {
            get
            {
                return polarization;
            }
        }

        /// <summary>
        /// Normalized Power Delay Profile (PDP): delays tau_n mapped to the normalized (fractional) powers p'_n. The fractional powers are expected to sum to 1.
        /// </summary>
        [JsonIgnore]
        public SimpleMultipathPowerDelayProfile? SimpleMultipathPowerDelayProfile
        {
            get
            {
                return Core.Query.Clone(simpleMultipathPowerDelayProfile);
            }
        }

        /// <summary>
        /// Normalized reception characteristic g(theta, phi) of the directional receiving antenna.
        /// </summary>
        [JsonIgnore]
        public AntennaCharacteristic? ReceivingDirectionalCharacteristic
        {
            get
            {
                return receivingDirectionalCharacteristic;
            }
        }

        /// <summary>
        /// Normalized reception characteristic g_0(theta, phi) of the omnidirectional receiving antenna.
        /// </summary>
        [JsonIgnore]
        public AntennaCharacteristic? ReceivingOmnidirectionalCharacteristic
        {
            get
            {
                return receivingOmnidirectionalCharacteristic;
            }
        }

        /// <summary>
        /// Normalized radiation characteristic g_T(theta, phi) of the directional transmitting antenna. Reserved for the transmitting-side comparison; not used by the receiving-side comparative analysis.
        /// </summary>
        [JsonIgnore]
        public AntennaCharacteristic? TransmittingDirectionalCharacteristic
        {
            get
            {
                return transmittingDirectionalCharacteristic;
            }
        }

        /// <summary>
        /// Normalized radiation characteristic g_T0(theta, phi) of the omnidirectional transmitting antenna.
        /// </summary>
        [JsonIgnore]
        public AntennaCharacteristic? TransmittingOmnidirectionalCharacteristic
        {
            get
            {
                return transmittingOmnidirectionalCharacteristic;
            }
        }
    }
}
