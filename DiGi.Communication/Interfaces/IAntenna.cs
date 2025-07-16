using DiGi.Communication.Enums;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Interfaces
{
    public interface IAntenna : ICommunicationGuidObject
    {
        HashSet<Function> Functions { get; }
        
        Point3D Location { get; }
    }
}
