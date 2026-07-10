using DiGi.Communication.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a geometrical propagation model used to define and manage communication relation clusters within the system.
    /// </summary>
    public class GeometricalPropagationModel : GuidObject, ICommunicationGuidObject, IGuidModel
    {
        [JsonInclude, JsonPropertyName("CommunicationRelationCluster"), Description("CommunicationRelationCluster")]
        private readonly CommunicationRelationCluster communicationRelationCluster = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometricalPropagationModel"/> class.
        /// </summary>
        public GeometricalPropagationModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometricalPropagationModel"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> from which to initialize the model.</param>
        public GeometricalPropagationModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometricalPropagationModel"/> class by copying an existing instance.
        /// </summary>
        /// <param name="geometricalPropagationModel">The source <see cref="GeometricalPropagationModel"/> instance to copy from, or <see langword="null"/>.</param>
        public GeometricalPropagationModel(GeometricalPropagationModel? geometricalPropagationModel)
            : base(geometricalPropagationModel)
        {
            if (geometricalPropagationModel != null)
            {
                communicationRelationCluster = Core.Query.Clone(geometricalPropagationModel.communicationRelationCluster) ?? [];
            }
        }

        /// <summary>
        /// Assigns a multipath power delay profile and two antennas to the geometrical propagation model.
        /// </summary>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile to be assigned.</param>
        /// <param name="antenna_1">The first antenna to be associated with the propagation model.</param>
        /// <param name="antenna_2">The second antenna to be associated with the propagation model.</param>
        /// <returns><c>true</c> if the assignment was successful; otherwise, <c>false</c>.</returns>
        public bool Assign(IMultipathPowerDelayProfile? multipathPowerDelayProfile, IAntenna? antenna_1, IAntenna? antenna_2)
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

        /// <summary>
        /// Assigns a scattering profile and two antennas to the geometrical propagation model.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to be assigned.</param>
        /// <param name="antenna_1">The first antenna involved in the propagation.</param>
        /// <param name="antenna_2">The second antenna involved in the propagation.</param>
        /// <returns><c>true</c> if the assignment was successful; otherwise, <c>false</c>.</returns>
        public bool Assign(IScatteringProfile? scatteringProfile, IAntenna? antenna_1, IAntenna? antenna_2)
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

        /// <summary>
        /// Assigns the specified scattering profile and multipath power delay profile to the propagation model.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to be assigned.</param>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile to be assigned.</param>
        /// <returns>True if the assignment was successful; otherwise, false.</returns>
        public bool Assign(IScatteringProfile? scatteringProfile, IMultipathPowerDelayProfile? multipathPowerDelayProfile)
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

        /// <summary>
        /// Assigns an angular power distribution profile and an antenna to the geometrical propagation model.
        /// </summary>
        /// <param name="angularPowerDistributionProfile">The angular power distribution profile to be assigned.</param>
        /// <param name="antenna">The antenna to be assigned.</param>
        /// <returns>True if the assignment was successful; otherwise, false.</returns>
        public bool Assign(IAngularPowerDistributionProfile? angularPowerDistributionProfile, IAntenna? antenna)
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

        /// <summary>
        /// Retrieves the list of angular power distribution profiles associated with the geometrical propagation model.
        /// </summary>
        /// <typeparam name="TAngularPowerDistributionProfile">The type of the angular power distribution profile, which must implement <see cref="IAngularPowerDistributionProfile"/>.</typeparam>
        /// <returns>A list of angular power distribution profiles of type <typeparamref name="TAngularPowerDistributionProfile"/>, or null if no such profiles are found.</returns>
        public List<TAngularPowerDistributionProfile>? GetAngularPowerDistributionProfiles<TAngularPowerDistributionProfile>() where TAngularPowerDistributionProfile : IAngularPowerDistributionProfile
        {
            return communicationRelationCluster.GetValues<TAngularPowerDistributionProfile>()?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves a list of antennas associated with the specified multipath power delay profile.
        /// </summary>
        /// <typeparam name="TAntenna">The type of antenna, which must implement the <see cref="IAntenna"/> interface.</typeparam>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile used to identify the associated antennas. Can be null.</param>
        /// <returns>A list of antennas of type <typeparamref name="TAntenna"/> if a valid profile is provided and relations are found; otherwise, null.</returns>
        public List<TAntenna>? GetAntennas<TAntenna>(IMultipathPowerDelayProfile? multipathPowerDelayProfile) where TAntenna : IAntenna
        {
            if (multipathPowerDelayProfile == null)
            {
                return null;
            }

            List<MultipathPowerDelayProfileAntennasRelation>? multipathPowerDelayProfileAntennasRelations = communicationRelationCluster.GetRelations<MultipathPowerDelayProfileAntennasRelation>(multipathPowerDelayProfile);
            if (multipathPowerDelayProfileAntennasRelations == null)
            {
                return null;
            }

            List<TAntenna> result = [];
            foreach (MultipathPowerDelayProfileAntennasRelation multipathPowerDelayProfileAntennasRelation in multipathPowerDelayProfileAntennasRelations)
            {
                List<TAntenna>? antennas = communicationRelationCluster.GetValues<TAntenna>(multipathPowerDelayProfileAntennasRelation, Core.Relation.Enums.RelationSide.To);
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

                    if (Core.Query.Clone(antenna) is TAntenna antenna_Temp)
                    {
                        result.Add(antenna_Temp);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of antennas based on the specified multipath power delay profile and antenna reference.
        /// </summary>
        /// <typeparam name="TAntenna">The type of antenna to be returned, which must implement <see cref="IAntenna"/>.</typeparam>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile used for the retrieval process.</param>
        /// <param name="antenna">The reference antenna used to identify the antennas to retrieve.</param>
        /// <returns>A list of antennas of type <typeparam ref="TAntenna"/> if the parameters are valid; otherwise, null.</returns>
        public List<TAntenna>? GetAntennas<TAntenna>(IMultipathPowerDelayProfile? multipathPowerDelayProfile, IAntenna? antenna) where TAntenna : IAntenna
        {
            if (multipathPowerDelayProfile == null || antenna == null)
            {
                return default;
            }

            if (Core.Create.UniqueReference(antenna) is not IUniqueReference uniqueReference)
            {
                return default;
            }

            List<MultipathPowerDelayProfileAntennasRelation>? multipathPowerDelayProfileAntennasRelations = communicationRelationCluster.GetRelations<MultipathPowerDelayProfileAntennasRelation>(multipathPowerDelayProfile, x => x?.UniqueReferences_To is List<IUniqueReference> uniqueReferences && x.UniqueReferences_To.Contains(uniqueReference));
            if (multipathPowerDelayProfileAntennasRelations == null)
            {
                return null;
            }

            List<TAntenna> result = [];
            foreach (MultipathPowerDelayProfileAntennasRelation multipathPowerDelayProfileAntennasRelation in multipathPowerDelayProfileAntennasRelations)
            {
                List<TAntenna>? antennas = communicationRelationCluster.GetValues<TAntenna>(multipathPowerDelayProfileAntennasRelation, Core.Relation.Enums.RelationSide.To);
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

                    if (Core.Query.Clone(antenna_Temp) is TAntenna antenna_Temp_Temp)
                    {
                        result.Add(antenna_Temp_Temp);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the list of antennas associated with the specified scattering profile.
        /// </summary>
        /// <typeparam name="TAntenna">The type of antenna, which must implement the <see cref="IAntenna"/> interface.</typeparam>
        /// <param name="scatteringProfile">The scattering profile used to identify the related antennas. If null, no antennas are retrieved.</param>
        /// <returns>A list of antennas of type <typeparamref name="TAntenna"/> associated with the provided scattering profile, or null if the profile is null or no relations are found.</returns>
        public List<TAntenna>? GetAntennas<TAntenna>(IScatteringProfile? scatteringProfile) where TAntenna : IAntenna
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            List<ScatteringProfileAntennasRelation>? scatteringProfileAntennasRelations = communicationRelationCluster.GetRelations<ScatteringProfileAntennasRelation>(Core.Create.UniqueReference(scatteringProfile));
            if (scatteringProfileAntennasRelations == null)
            {
                return null;
            }

            List<TAntenna> result = [];
            foreach (ScatteringProfileAntennasRelation scatteringProfileAntennasRelation in scatteringProfileAntennasRelations)
            {
                List<TAntenna>? antennas = communicationRelationCluster.GetValues<TAntenna>(scatteringProfileAntennasRelation, Core.Relation.Enums.RelationSide.To);
                if (antennas == null)
                {
                    continue;
                }

                result.AddRange(Core.Query.CloneAndFilterNulls(antennas));
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of antennas of the specified type associated with this geometrical propagation model.
        /// </summary>
        /// <typeparam name="TAntenna">The type of antenna to retrieve, which must implement <see cref="IAntenna"/>.</typeparam>
        /// <returns>A list of antennas of type <typeparamref name="TAntenna"/> if any are found; otherwise, null.</returns>
        public List<TAntenna>? GetAntennas<TAntenna>() where TAntenna : IAntenna
        {
            return communicationRelationCluster.GetValues<TAntenna>()?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves the multipath power delay profile associated with the specified scattering profile.
        /// </summary>
        /// <typeparam name="TMultipathPowerDelayProfile">The type of the multipath power delay profile to retrieve, which must implement <see cref="IMultipathPowerDelayProfile"/>.</typeparam>
        /// <param name="scatteringProfile">The scattering profile for which the multipath power delay profile is retrieved.</param>
        /// <returns>The multipath power delay profile of type <typeparamref name="TMultipathPowerDelayProfile"/> if a relation exists; otherwise, null.</returns>
        public TMultipathPowerDelayProfile? GetMultipathPowerDelayProfile<TMultipathPowerDelayProfile>(IScatteringProfile? scatteringProfile) where TMultipathPowerDelayProfile : IMultipathPowerDelayProfile
        {
            if (scatteringProfile == null)
            {
                return default;
            }

            ScatteringProfileMultipathPowerDelayProfileRelation? scatteringProfileMultipathPowerDelayProfileRelation = communicationRelationCluster.GetRelation<ScatteringProfileMultipathPowerDelayProfileRelation>(scatteringProfile);
            if (scatteringProfileMultipathPowerDelayProfileRelation == null)
            {
                return default;
            }

            List<TMultipathPowerDelayProfile>? multipathPowerDelayProfiles = communicationRelationCluster.GetValues<TMultipathPowerDelayProfile>(scatteringProfileMultipathPowerDelayProfileRelation, Core.Relation.Enums.RelationSide.To);

            return multipathPowerDelayProfiles == null || multipathPowerDelayProfiles.Count == 0 ? default : Core.Query.Clone(multipathPowerDelayProfiles[0]);
        }

        /// <summary>
        /// Retrieves a list of multipath power delay profiles of the specified type from the communication relation cluster.
        /// </summary>
        /// <typeparam name="TMultipathPowerDelayProfile">The type of multipath power delay profile to retrieve, which must implement <see cref="IMultipathPowerDelayProfile"/>.</typeparam>
        /// <returns>A list of <typeparamref name="TMultipathPowerDelayProfile"/> objects if available; otherwise, <c>null</c>.</returns>
        public List<TMultipathPowerDelayProfile>? GetMultipathPowerDelayProfiles<TMultipathPowerDelayProfile>() where TMultipathPowerDelayProfile : IMultipathPowerDelayProfile
        {
            return communicationRelationCluster.GetValues<TMultipathPowerDelayProfile>()?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves a list of scattering objects of the specified type from the communication relation cluster.
        /// </summary>
        /// <typeparam name="TScatteringObject">The type of scattering object to retrieve, which must implement <see cref="IScatteringObject"/>.</typeparam>
        /// <returns>A list of scattering objects of type <typeparamref name="TScatteringObject"/>, or <c>null</c> if the collection is empty or unavailable.</returns>
        public List<TScatteringObject>? GetScatteringObjects<TScatteringObject>() where TScatteringObject : IScatteringObject
        {
            return communicationRelationCluster.GetValues<TScatteringObject>()?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves the scattering profiles between two specified antennas.
        /// </summary>
        /// <typeparam name="TScatteringProfile">The type of scattering profile to retrieve, which must implement <see cref="IScatteringProfile"/>.</typeparam>
        /// <param name="antenna_1">The first antenna involved in the propagation path.</param>
        /// <param name="antenna_2">The second antenna involved in the propagation path.</param>
        /// <returns>A list of scattering profiles if both antennas are provided; otherwise, null.</returns>
        public List<TScatteringProfile>? GetScatteringProfiles<TScatteringProfile>(IAntenna? antenna_1, IAntenna? antenna_2) where TScatteringProfile : IScatteringProfile
        {
            if (antenna_1 == null || antenna_2 == null)
            {
                return default;
            }

            if (Core.Create.UniqueReference(antenna_1) is not IUniqueReference uniqueReference_1)
            {
                return default;
            }

            if (Core.Create.UniqueReference(antenna_2) is not IUniqueReference uniqueReference_2)
            {
                return default;
            }

            List<ScatteringProfileAntennasRelation>? scatteringAntennasRelations = communicationRelationCluster.GetRelations<ScatteringProfileAntennasRelation>(uniqueReference_1, x => x?.UniqueReferences_To is List<IUniqueReference> uniqueReferences && uniqueReferences.Contains(uniqueReference_2));
            if (scatteringAntennasRelations is null)
            {
                return null;
            }

            List<TScatteringProfile> result = [];
            foreach (ScatteringProfileAntennasRelation scatteringProfileAntennasRelation in scatteringAntennasRelations)
            {
                List<TScatteringProfile>? scatteringProfiles = communicationRelationCluster.GetValues<TScatteringProfile>(scatteringProfileAntennasRelation, Core.Relation.Enums.RelationSide.From);
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

                    if (Core.Query.Clone(scatteringProfile) is TScatteringProfile scatteringProfile_Temp)
                    {
                        result.Add(scatteringProfile_Temp);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of scattering profiles of the specified type associated with the propagation model.
        /// </summary>
        /// <typeparam name="TScatteringProfile">The type of scattering profile to retrieve, which must implement <see cref="IScatteringProfile"/>.</typeparam>
        /// <returns>A list of scattering profiles of type <typeparamref name="TScatteringProfile"/> if any are found; otherwise, null.</returns>
        public List<TScatteringProfile>? GetScatteringProfiles<TScatteringProfile>() where TScatteringProfile : IScatteringProfile
        {
            return communicationRelationCluster.GetValues<TScatteringProfile>()?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Performs an update operation and returns whether any changes were made.
        /// </summary>
        /// <param name="antenna">The antenna to be updated in the propagation model.</param>
        /// <returns><c>true</c> if the antenna was successfully added; otherwise, <c>false</c>.</returns>
        public bool Update(IAntenna? antenna)
        {
            if (antenna == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(antenna));
        }

        /// <summary>
        /// Updates the propagation model using the specified multipath power delay profile.
        /// </summary>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile to be used for the update; can be null.</param>
        /// <returns><c>true</c> if the update was successful and changes were made; otherwise, <c>false</c>.</returns>
        public bool Update(IMultipathPowerDelayProfile? multipathPowerDelayProfile)
        {
            if (multipathPowerDelayProfile == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(multipathPowerDelayProfile));
        }

        /// <summary>
        /// Updates the propagation model by adding the specified scattering object to the communication relation cluster.
        /// </summary>
        /// <param name="scatteringObject">The scattering object to be added. If null, no update is performed.</param>
        /// <returns><c>true</c> if the scattering object was successfully added; otherwise, <c>false</c>.</returns>
        public bool Update(IScatteringObject? scatteringObject)
        {
            if (scatteringObject == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(scatteringObject));
        }

        /// <summary>
        /// Performs an update operation and returns whether any changes were made.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to be used for the update. Can be null.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        public bool Update(IScatteringProfile? scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(scatteringProfile));
        }

        /// <summary>
        /// Performs an update operation by adding a cloned angular power distribution profile to the communication relation cluster.
        /// </summary>
        /// <param name="angularPowerDistributionProfile">The angular power distribution profile to be used for the update. Can be null.</param>
        /// <returns>True if the update was successful and changes were made; otherwise, false.</returns>
        public bool Update(IAngularPowerDistributionProfile? angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile == null)
            {
                return false;
            }

            return communicationRelationCluster.Add(Core.Query.Clone(angularPowerDistributionProfile));
        }
    }
}