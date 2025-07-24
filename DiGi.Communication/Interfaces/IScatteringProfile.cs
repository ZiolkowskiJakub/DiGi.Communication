using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.Interfaces
{
    public interface IScatteringProfile : ICommunicationGuidObject
    {
        IEnumerable<Scattering> Scatterings { get; }

        bool Visible { get; }

        Point3D Location_1 { get; }
        
        Point3D Location_2 { get; }

    }
}
