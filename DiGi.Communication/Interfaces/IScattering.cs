using DiGi.Communication.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    public interface IScattering : ICommunicationSerializableObject
    {
        double Delay { get; }

        public List<ScatteringPointGroup>? ScatteringPointGroups { get; }
    }
}
