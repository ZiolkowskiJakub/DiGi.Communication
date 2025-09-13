using DiGi.Communication.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Communication.Interfaces
{
    public interface IAngularPowerDistributionProfile : ICommunicationGuidObject
    {
        Point3D? Location { get; }

        IEnumerable<AngularPowerDistribution>? AngularPowerDistributions { get; }

        List<Ray>? GetRays(double delay);
    }
}
