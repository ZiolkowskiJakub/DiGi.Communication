using DiGi.Communication.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class GeometricalPropagationModel : GuidObject, ICommunicationGuidObject, IGuidModel
    {
        [JsonInclude, JsonPropertyName("CommunicationRelationCluster"), Description("CommunicationRelationCluster")]
        private CommunicationRelationCluster communicationRelationCluster = new CommunicationRelationCluster();

        public GeometricalPropagationModel()
            : base()
        {

        }

        public GeometricalPropagationModel(JsonObject jsonObject)
            :base(jsonObject)
        {
            
        }

        public GeometricalPropagationModel(GeometricalPropagationModel geometricalPropagationModel)
            : base(geometricalPropagationModel)
        {
            if(geometricalPropagationModel != null)
            {
                communicationRelationCluster = Core.Query.Clone(geometricalPropagationModel.communicationRelationCluster);
            }
        }

        public bool Assign(IMultipathPowerDelayProfile multipathPowerDelayProfile, IAntenna antenna_1, IAntenna antenna_2)
        {
            if (multipathPowerDelayProfile == null || antenna_1 == null || antenna_2 == null)
            {
                return false;
            }

            if (!Update(multipathPowerDelayProfile))
            {
                return false;
            }

            if (!Update(antenna_1))
            {
                return false;
            }

            if (!Update(antenna_2))
            {
                return false;
            }

            return communicationRelationCluster.AddRelation(multipathPowerDelayProfile, antenna_1, antenna_2) != null;
        }

        public bool Assign(IScatteringProfile scatteringProfile, IAntenna antenna_1, IAntenna antenna_2)
        {
            if (scatteringProfile == null || antenna_1 == null || antenna_2 == null)
            {
                return false;
            }

            if (!Update(scatteringProfile))
            {
                return false;
            }

            if (!Update(antenna_1))
            {
                return false;
            }

            if (!Update(antenna_2))
            {
                return false;
            }

            return communicationRelationCluster.AddRelation(scatteringProfile, antenna_1, antenna_2) != null;
        }

        public bool Assign(IScatteringProfile scatteringProfile, IMultipathPowerDelayProfile multipathPowerDelayProfile)
        {
            if (scatteringProfile == null || multipathPowerDelayProfile == null)
            {
                return false;
            }

            if (!Update(scatteringProfile))
            {
                return false;
            }

            if (!Update(multipathPowerDelayProfile))
            {
                return false;
            }


            return communicationRelationCluster.AddRelation(scatteringProfile, multipathPowerDelayProfile) != null;
        }

        public bool Assign(IAngularPowerDistributionProfile angularPowerDistributionProfile, IAntenna antenna)
        {
            if (angularPowerDistributionProfile == null || antenna == null)
            {
                return false;
            }

            if (!Update(angularPowerDistributionProfile))
            {
                return false;
            }

            if (!Update(antenna))
            {
                return false;
            }

            return communicationRelationCluster.AddRelation(angularPowerDistributionProfile, antenna) != null;
        }

        public List<TAngularPowerDistributionProfile> GetAngularPowerDistributionProfiles<TAngularPowerDistributionProfile>() where TAngularPowerDistributionProfile : IAngularPowerDistributionProfile
        {
            return communicationRelationCluster.GetValues<TAngularPowerDistributionProfile>()?.ConvertAll(x => Core.Query.Clone(x));
        }

        public List<TAntenna> GetAntennas<TAntenna>(IMultipathPowerDelayProfile multipathPowerDelayProfile) where TAntenna : IAntenna
        {
            if (multipathPowerDelayProfile == null)
            {
                return null;
            }

            List<MultipathPowerDelayProfileAntennasRelation> multipathPowerDelayProfileAntennasRelations = communicationRelationCluster.GetRelations<MultipathPowerDelayProfileAntennasRelation>(multipathPowerDelayProfile);
            if (multipathPowerDelayProfileAntennasRelations == null)
            {
                return null;
            }

            List<TAntenna> result = new List<TAntenna>();
            foreach (MultipathPowerDelayProfileAntennasRelation multipathPowerDelayProfileAntennasRelation in multipathPowerDelayProfileAntennasRelations)
            {
                List<TAntenna> antennas = communicationRelationCluster.GetValues<TAntenna>(multipathPowerDelayProfileAntennasRelation, Core.Relation.Enums.RelationSide.To);
                if (antennas == null)
                {
                    continue;
                }

                foreach (TAntenna antenna in antennas)
                {
                    if (result.Find(x => x.Guid == antenna.Guid) != null)
                    {
                        continue;
                    }

                    result.Add(Core.Query.Clone(antenna));
                }
            }

            return result;
        }

        public List<TAntenna> GetAntennas<TAntenna>(IMultipathPowerDelayProfile multipathPowerDelayProfile, IAntenna antenna) where TAntenna : IAntenna
        {
            if (multipathPowerDelayProfile == null || antenna == null)
            {
                return default;
            }

            IUniqueReference uniqueReference = Core.Create.UniqueReference(antenna);

            List<MultipathPowerDelayProfileAntennasRelation> multipathPowerDelayProfileAntennasRelations = communicationRelationCluster.GetRelations<MultipathPowerDelayProfileAntennasRelation>(multipathPowerDelayProfile, x => x.UniqueReferences_To.Contains(uniqueReference));
            if (multipathPowerDelayProfileAntennasRelations == null)
            {
                return null;
            }

            List<TAntenna> result = new List<TAntenna>();
            foreach (MultipathPowerDelayProfileAntennasRelation multipathPowerDelayProfileAntennasRelation in multipathPowerDelayProfileAntennasRelations)
            {
                List<TAntenna> antennas = communicationRelationCluster.GetValues<TAntenna>(multipathPowerDelayProfileAntennasRelation, Core.Relation.Enums.RelationSide.To);
                if (antennas == null)
                {
                    continue;
                }

                foreach (TAntenna antenna_Temp in antennas)
                {
                    if (antenna_Temp.Guid == antenna.Guid)
                    {
                        continue;
                    }

                    if (result.Find(x => x.Guid == antenna_Temp.Guid) != null)
                    {
                        continue;
                    }

                    result.Add(Core.Query.Clone(antenna_Temp));
                }
            }

            return result;
        }

        public List<TAntenna> GetAntennas<TAntenna>(IScatteringProfile scatteringProfile) where TAntenna : IAntenna
        {
            if(scatteringProfile == null)
            {
                return null;
            }

            List<ScatteringProfileAntennasRelation> scatteringProfileAntennasRelations = communicationRelationCluster.GetRelations<ScatteringProfileAntennasRelation>(Core.Create.UniqueReference(scatteringProfile));
            if(scatteringProfileAntennasRelations == null)
            {
                return null;
            }

            List<TAntenna> result = new List<TAntenna>();
            foreach(ScatteringProfileAntennasRelation scatteringProfileAntennasRelation in scatteringProfileAntennasRelations)
            {
                List<TAntenna> antennas = communicationRelationCluster.GetValues<TAntenna>(scatteringProfileAntennasRelation, Core.Relation.Enums.RelationSide.To);
                if(antennas == null)
                {
                    continue;
                }

                result.AddRange(Core.Query.Clone(antennas));
            }

            return result;
        }

        public List<TAntenna> GetAntennas<TAntenna>() where TAntenna : IAntenna
        {
            return communicationRelationCluster.GetValues<TAntenna>()?.ConvertAll(x => Core.Query.Clone(x));
        }

        public TMultipathPowerDelayProfile GetMultipathPowerDelayProfile<TMultipathPowerDelayProfile>(IScatteringProfile scatteringProfile) where TMultipathPowerDelayProfile : IMultipathPowerDelayProfile
        {
            if(scatteringProfile == null)
            {
                return default;
            }

            ScatteringProfileMultipathPowerDelayProfileRelation scatteringProfileMultipathPowerDelayProfileRelation = communicationRelationCluster.GetRelation<ScatteringProfileMultipathPowerDelayProfileRelation>(scatteringProfile);
            if(scatteringProfileMultipathPowerDelayProfileRelation == null)
            {
                return default;
            }

            List<TMultipathPowerDelayProfile> multipathPowerDelayProfiles = communicationRelationCluster.GetValues<TMultipathPowerDelayProfile>(scatteringProfileMultipathPowerDelayProfileRelation, Core.Relation.Enums.RelationSide.To);

            return multipathPowerDelayProfiles == null || multipathPowerDelayProfiles.Count == 0 ? default : Core.Query.Clone(multipathPowerDelayProfiles[0]);
        }

        public List<TMultipathPowerDelayProfile> GetMultipathPowerDelayProfiles<TMultipathPowerDelayProfile>() where TMultipathPowerDelayProfile : IMultipathPowerDelayProfile
        {
            return communicationRelationCluster.GetValues<TMultipathPowerDelayProfile>()?.ConvertAll(x => Core.Query.Clone(x));
        }

        public List<TScatteringObject> GetScatteringObjects<TScatteringObject>() where TScatteringObject : IScatteringObject
        {
            return communicationRelationCluster.GetValues<TScatteringObject>()?.ConvertAll(x => Core.Query.Clone(x));
        }

        public List<TScatteringProfile> GetScatteringProfiles<TScatteringProfile>(IAntenna antenna_1, IAntenna antenna_2) where TScatteringProfile : IScatteringProfile
        {
            if (antenna_1 == null || antenna_2 == null)
            {
                return default;
            }

            IUniqueReference uniqueReference_1 = Core.Create.UniqueReference(antenna_1);
            IUniqueReference uniqueReference_2 = Core.Create.UniqueReference(antenna_2);

            List<ScatteringProfileAntennasRelation> scatteringAntennasRelations = communicationRelationCluster.GetRelations<ScatteringProfileAntennasRelation>(uniqueReference_1, x => x.UniqueReferences_To.Contains(uniqueReference_2));
            if (scatteringAntennasRelations == null)
            {
                return null;
            }

            List<TScatteringProfile> result = new List<TScatteringProfile>();
            foreach (ScatteringProfileAntennasRelation scatteringProfileAntennasRelation in scatteringAntennasRelations)
            {
                List<TScatteringProfile> scatteringProfiles = communicationRelationCluster.GetValues<TScatteringProfile>(scatteringProfileAntennasRelation, Core.Relation.Enums.RelationSide.From);
                if (scatteringProfiles == null)
                {
                    continue;
                }

                foreach (TScatteringProfile scatteringProfile in scatteringProfiles)
                {
                    if (result.Find(x => x.Guid == scatteringProfile.Guid) != null)
                    {
                        continue;
                    }

                    result.Add(Core.Query.Clone(scatteringProfile));
                }
            }

            return result;
        }

        public List<TScatteringProfile> GetScatteringProfiles<TScatteringProfile>() where TScatteringProfile : IScatteringProfile
        {
            return communicationRelationCluster.GetValues<TScatteringProfile>()?.ConvertAll(x => Core.Query.Clone(x));
        }

        public bool Update(IAntenna antenna)
        {
            if (antenna == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(antenna));
        }

        public bool Update(IMultipathPowerDelayProfile multipathPowerDelayProfile)
        {
            if (multipathPowerDelayProfile == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(multipathPowerDelayProfile));
        }

        public bool Update(IScatteringObject scatteringObject)
        {
            if (scatteringObject == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(scatteringObject));
        }

        public bool Update(IScatteringProfile scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(scatteringProfile));
        }

        public bool Update(IAngularPowerDistributionProfile angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(angularPowerDistributionProfile));
        }
    }
}
