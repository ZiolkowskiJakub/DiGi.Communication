using DiGi.Communication.Enums;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for an antenna with a location and a set of communication functions.
    /// </summary>
    public interface IAntenna : ICommunicationGuidObject
    {
        /// <summary>
        /// Gets the set of communication functions (e.g. transmitter, receiver) supported by the antenna.
        /// </summary>
        HashSet<Function>? Functions { get; }

        /// <summary>
        /// Gets the spatial location of the antenna.
        /// </summary>
        Point3D? Location { get; }
    }
}