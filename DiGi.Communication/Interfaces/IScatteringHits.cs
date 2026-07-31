using DiGi.Communication.Enums;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for a collection of hit points resulting from scattering ray intersections, containing reference identifier, electrical properties, and ray geometry.
    /// </summary>
    public interface IScatteringHits : ICommunicationSerializableObject
    {
        /// <summary>
        /// Gets the electrical properties of the scattering object.
        /// </summary>
        Classes.ElectricalProperties? ElectricalProperties { get; }

        /// <summary>
        /// Gets the frequency in Hertz [Hz].
        /// </summary>
        double Frequency { get; }

        /// <summary>
        /// Gets the 3D location of the receiver.
        /// </summary>
        Point3D? Location_Receiver { get; }

        /// <summary>
        /// Gets the 3D location of the transmitter.
        /// </summary>
        Point3D? Location_Transmitter { get; }

        /// <summary>
        /// Gets the list of 3D hit locations.
        /// </summary>
        List<Point3D>? Locations { get; }

        /// <summary>
        /// Gets the reference identifier of the hit scattering object.
        /// </summary>
        string? Reference { get; }
    }
}
