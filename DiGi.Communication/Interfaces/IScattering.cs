using DiGi.Communication.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a scattering event that groups scattering points by a common propagation delay.
    /// </summary>
    public interface IScattering : ICommunicationSerializableObject
    {
        /// <summary>
        /// Gets the propagation delay [s] associated with this scattering event.
        /// </summary>
        double Delay { get; }

        /// <summary>
        /// Gets the list of scattering point groups associated with this scattering event.
        /// </summary>
        public List<ScatteringPointGroup>? ScatteringPointGroups { get; }
    }
}