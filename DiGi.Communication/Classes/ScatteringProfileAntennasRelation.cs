using DiGi.Communication.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    public class ScatteringProfileAntennasRelation : OneToManyDirectionalRelation<IScatteringProfile, IAntenna>, ICommunicationRelation
    {
        public ScatteringProfileAntennasRelation(IScatteringProfile scatteringProfile, IAntenna antenna_1, IAntenna antenna_2)
            : base(scatteringProfile, [antenna_1, antenna_2])
        {

        }

        public ScatteringProfileAntennasRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ScatteringProfileAntennasRelation(ScatteringProfileAntennasRelation scatteringProfileAntennasRelation)
            : base(scatteringProfileAntennasRelation)
        {

        }
    }
}
