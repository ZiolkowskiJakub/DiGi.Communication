using DiGi.Communication.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    public class ScatteringProfileMultipathPowerDelayProfileRelation : OneToOneBidirectionalRelation<IScatteringProfile, IMultipathPowerDelayProfile>, ICommunicationRelation
    {
        public ScatteringProfileMultipathPowerDelayProfileRelation(IScatteringProfile scatteringProfile, IMultipathPowerDelayProfile multipathPowerDelayProfile)
            : base(scatteringProfile, multipathPowerDelayProfile)
        {

        }

        public ScatteringProfileMultipathPowerDelayProfileRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ScatteringProfileMultipathPowerDelayProfileRelation(ScatteringProfileMultipathPowerDelayProfileRelation scatteringProfileMultipathPowerDelayProfileRelation)
            : base(scatteringProfileMultipathPowerDelayProfileRelation)
        {

        }
    }
}
