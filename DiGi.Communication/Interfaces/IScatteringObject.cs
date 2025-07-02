using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Interfaces
{
    public interface IScatteringObject : ISerializableObject, ICommunicationObject
    {
        Mesh3D Mesh3D { get; }
        string Reference { get; }
    }
}
