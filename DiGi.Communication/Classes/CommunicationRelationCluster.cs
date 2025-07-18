using DiGi.Communication.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    public class CommunicationRelationCluster : UniqueObjectRelationCluster<ICommunicationGuidObject, ICommunicationRelation>, ICommunicationSerializableObject
    {
        public CommunicationRelationCluster()
            : base()
        {

        }

        public CommunicationRelationCluster(JsonObject jsonObject)
            :base(jsonObject)
        {
            
        }

        public CommunicationRelationCluster(CommunicationRelationCluster communicationRelationCluster)
            : base(communicationRelationCluster)
        {
            if(communicationRelationCluster != null)
            {

            }
        }

        public MultipathPowerDelayProfileAntennasRelation AddRelation(IMultipathPowerDelayProfile multipathPowerDelayProfile, IAntenna antenna_1, IAntenna antenna_2)
        {
            if (multipathPowerDelayProfile == null || antenna_1 == null || antenna_2 == null)
            {
                return null;
            }

            IUniqueReference uniqueReference_1 = Core.Create.UniqueReference(antenna_1);
            IUniqueReference uniqueReference_2 = Core.Create.UniqueReference(antenna_2);

            MultipathPowerDelayProfileAntennasRelation multipathPowerDelayProfileAntennasRelation = GetRelation<MultipathPowerDelayProfileAntennasRelation>(Core.Create.UniqueReference(multipathPowerDelayProfile), x => x.UniqueReferences_To.Contains(uniqueReference_1) && x.UniqueReferences_To.Contains(uniqueReference_2));
            if (multipathPowerDelayProfileAntennasRelation != null)
            {
                Remove(multipathPowerDelayProfileAntennasRelation);
            }

            return AddRelation(new MultipathPowerDelayProfileAntennasRelation(multipathPowerDelayProfile, antenna_1, antenna_2));
        }

        public ScatteringProfileAntennasRelation AddRelation(IScatteringProfile scatteringProfile, IAntenna antenna_1, IAntenna antenna_2)
        {
            if (scatteringProfile == null || antenna_1 == null || antenna_2 == null)
            {
                return null;
            }

            IUniqueReference uniqueReference_1 = Core.Create.UniqueReference(antenna_1);
            IUniqueReference uniqueReference_2 = Core.Create.UniqueReference(antenna_2);

            List<ScatteringProfileAntennasRelation> scatteringProfileAntennasRelations = GetRelations<ScatteringProfileAntennasRelation>(Core.Create.UniqueReference(scatteringProfile), x => x.UniqueReferences_To.Contains(uniqueReference_1) && x.UniqueReferences_To.Contains(uniqueReference_2));
            if (scatteringProfileAntennasRelations != null)
            {
                foreach(ScatteringProfileAntennasRelation scatteringAntennasRelation in scatteringProfileAntennasRelations)
                {
                    Remove(scatteringAntennasRelation);
                }
            }

            return AddRelation(new ScatteringProfileAntennasRelation(scatteringProfile, antenna_1, antenna_2));
        }

        public ScatteringProfileMultipathPowerDelayProfileRelation AddRelation(IScatteringProfile scatteringProfile, IMultipathPowerDelayProfile multipathPowerDelayProfile)
        {
            if (scatteringProfile == null || multipathPowerDelayProfile == null)
            {
                return null;
            }

            IUniqueReference uniqueReference = Core.Create.UniqueReference(multipathPowerDelayProfile);

            List<ScatteringProfileMultipathPowerDelayProfileRelation> scatteringProfileMultipathPowerDelayProfileRelations = GetRelations<ScatteringProfileMultipathPowerDelayProfileRelation>(Core.Create.UniqueReference(scatteringProfile), x => x.UniqueReference_To.ToString() == uniqueReference.ToString());
            if (scatteringProfileMultipathPowerDelayProfileRelations != null)
            {
                foreach (ScatteringProfileMultipathPowerDelayProfileRelation scatteringProfileMultipathPowerDelayProfileRelation in scatteringProfileMultipathPowerDelayProfileRelations)
                {
                    Remove(scatteringProfileMultipathPowerDelayProfileRelation);
                }
            }

            return AddRelation(new ScatteringProfileMultipathPowerDelayProfileRelation(scatteringProfile, multipathPowerDelayProfile));
        }

        public AngularPowerDistributionProfileAntennaRelation AddRelation(IAngularPowerDistributionProfile angularPowerDistributionProfile, IAntenna antenna)
        {
            if (angularPowerDistributionProfile == null || antenna == null)
            {
                return null;
            }

            IUniqueReference uniqueReference = Core.Create.UniqueReference(antenna);

            AngularPowerDistributionProfileAntennaRelation multipathPowerDelayProfileAntennasRelation = GetRelation<AngularPowerDistributionProfileAntennaRelation>(Core.Create.UniqueReference(angularPowerDistributionProfile), x => x.UniqueReference_To.ToString() == uniqueReference.ToString());
            if (multipathPowerDelayProfileAntennasRelation != null)
            {
                Remove(multipathPowerDelayProfileAntennasRelation);
            }

            return AddRelation(new AngularPowerDistributionProfileAntennaRelation(angularPowerDistributionProfile, antenna));
        }
    }
}
