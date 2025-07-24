using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Interfaces
{
    public interface IScatteringObject : ICommunicationGuidObject
    {
        Mesh3D Mesh3D { get; }
        string Reference { get; }
        double ScatteringCoefficient { get; }
    }
}
