using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for an angular power distribution at a given delay, describing power arrival directions as a set of vectors.
    /// </summary>
    public interface IAngularPowerDistribution : ICommunicationSerializableObject
    {
        /// <summary>
        /// Gets the propagation delay associated with this power distribution [s].
        /// </summary>
        double Delay { get; }

        /// <summary>
        /// Gets the list of direction vectors representing the angular distribution of power.
        /// </summary>
        List<Vector3D>? Vectors { get; }

        /// <summary>
        /// Computes the total power of this angular distribution.
        /// </summary>
        /// <returns>The total power value.</returns>
        double GetPower();
    }
}