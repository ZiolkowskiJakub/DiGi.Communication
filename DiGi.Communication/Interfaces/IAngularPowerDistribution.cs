using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    public interface IAngularPowerDistribution : ICommunicationSerializableObject
    {
        double Delay { get; }

        List<Vector3D>? Vectors { get; }

        double GetPower();
    }
}