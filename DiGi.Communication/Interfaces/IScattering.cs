using DiGi.Communication.Classes;

namespace DiGi.Communication.Interfaces
{
    public interface IScattering : ICommunicationSerializableObject
    {
        double Delay { get; }

        public List<ScatteringPointGroup> ScatteringPointGroups { get; }
    }
}
