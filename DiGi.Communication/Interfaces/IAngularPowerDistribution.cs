using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Interfaces
{
    public interface IAngularPowerDistribution : ICommunicationSerializableObject
    {
        double Delay { get; }

        List<Vector3D> Vectors { get; }

        double GetPower();
    }
}
