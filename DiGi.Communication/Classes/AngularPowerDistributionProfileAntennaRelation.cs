using DiGi.Communication.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    public class AngularPowerDistributionProfileAntennaRelation : OneToOneDirectionalRelation<IAngularPowerDistributionProfile, IAntenna>, ICommunicationRelation
    {
        public AngularPowerDistributionProfileAntennaRelation(IAngularPowerDistributionProfile angularPowerDistributionProfile, IAntenna antenna)
            : base(angularPowerDistributionProfile, antenna)
        {

        }

        public AngularPowerDistributionProfileAntennaRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public AngularPowerDistributionProfileAntennaRelation(AngularPowerDistributionProfileAntennaRelation angularPowerDistributionProfileAntennaRelation)
            : base(angularPowerDistributionProfileAntennaRelation)
        {

        }
    }
}
