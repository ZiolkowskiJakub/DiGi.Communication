using DiGi.Communication.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    public class MultipathPowerDelayProfileAntennasRelation : OneToManyBidirectionalRelation<IMultipathPowerDelayProfile, IAntenna>, ICommunicationRelation
    {
        public MultipathPowerDelayProfileAntennasRelation(IMultipathPowerDelayProfile multipathPowerDelayProfile, IAntenna antenna_1, IAntenna antenna_2)
            : base(multipathPowerDelayProfile, [antenna_1, antenna_2])
        {

        }

        public MultipathPowerDelayProfileAntennasRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public MultipathPowerDelayProfileAntennasRelation(MultipathPowerDelayProfileAntennasRelation multipathPowerDelayProfileAntennasRelation)
            : base(multipathPowerDelayProfileAntennasRelation)
        {

        }
    }
}
