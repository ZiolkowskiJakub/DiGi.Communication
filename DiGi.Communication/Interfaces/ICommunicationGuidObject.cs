using DiGi.Core.Interfaces;

namespace DiGi.Communication.Interfaces
{
    /// <summary>
    /// Interface for communication objects that combine serialization support with a globally unique identifier.
    /// </summary>
    public interface ICommunicationGuidObject : ICommunicationSerializableObject, IGuidObject
    {
    }
}