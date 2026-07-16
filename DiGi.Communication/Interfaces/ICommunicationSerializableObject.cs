using DiGi.Core.Interfaces;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for communication objects that support serialization.
    /// </summary>
    public interface ICommunicationSerializableObject : ISerializableObject, ICommunicationObject
    {
    }
}