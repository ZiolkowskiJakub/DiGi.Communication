using DiGi.Communication.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a cluster of communication relations, providing functionality to manage unique relationships between communication GUID objects and communication relations while supporting serialization.
    /// </summary>
    public class CommunicationRelationCluster : UniqueObjectRelationCluster<ICommunicationGuidObject, ICommunicationRelation>, ICommunicationSerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationRelationCluster"/> class.
        /// </summary>
        public CommunicationRelationCluster()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationRelationCluster"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the cluster, which may be null.</param>
        public CommunicationRelationCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationRelationCluster"/> class, optionally copying data from an existing cluster.
        /// </summary>
        /// <param name="communicationRelationCluster">The source communication relation cluster to initialize from, or <see langword="null"/> to create a new empty instance.</param>
        public CommunicationRelationCluster(CommunicationRelationCluster? communicationRelationCluster)
            : base(communicationRelationCluster)
        {
            if (communicationRelationCluster != null)
            {
            }
        }

        /// <summary>
        /// Adds a relation between a multipath power delay profile and two antennas.
        /// </summary>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile to be associated.</param>
        /// <param name="antenna_1">The first antenna involved in the relation.</param>
        /// <param name="antenna_2">The second antenna involved in the relation.</param>
        /// <returns>The created <see cref="MultipathPowerDelayProfileAntennasRelation"/> if successful; otherwise, <c>null</c>.</returns>
        public MultipathPowerDelayProfileAntennasRelation? AddRelation(IMultipathPowerDelayProfile? multipathPowerDelayProfile, IAntenna? antenna_1, IAntenna? antenna_2)
        {
            if (multipathPowerDelayProfile == null || antenna_1 == null || antenna_2 == null)
            {
                return null;
            }

            if (Core.Create.UniqueReference(antenna_1) is not IUniqueReference uniqueReference_1)
            {
                return default;
            }

            if (Core.Create.UniqueReference(antenna_2) is not IUniqueReference uniqueReference_2)
            {
                return default;
            }

            MultipathPowerDelayProfileAntennasRelation? multipathPowerDelayProfileAntennasRelation = GetRelation<MultipathPowerDelayProfileAntennasRelation>(Core.Create.UniqueReference(multipathPowerDelayProfile), x => x?.UniqueReferences_To is List<IUniqueReference> uniqueReferences && uniqueReferences.Contains(uniqueReference_1) && uniqueReferences.Contains(uniqueReference_2));
            if (multipathPowerDelayProfileAntennasRelation != null)
            {
                Remove(multipathPowerDelayProfileAntennasRelation);
            }

            return AddRelation(new MultipathPowerDelayProfileAntennasRelation(multipathPowerDelayProfile, antenna_1, antenna_2));
        }

        /// <summary>
        /// Adds a relation between a scattering profile and two antennas.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to associate with the antennas.</param>
        /// <param name="antenna_1">The first antenna involved in the relation.</param>
        /// <param name="antenna_2">The second antenna involved in the relation.</param>
        /// <returns>A <see cref="ScatteringProfileAntennasRelation"/> if the relation was successfully created; otherwise, <c>null</c>.</returns>
        public ScatteringProfileAntennasRelation? AddRelation(IScatteringProfile? scatteringProfile, IAntenna? antenna_1, IAntenna? antenna_2)
        {
            if (scatteringProfile == null || antenna_1 == null || antenna_2 == null)
            {
                return null;
            }

            if (Core.Create.UniqueReference(antenna_1) is not IUniqueReference uniqueReference_1)
            {
                return null;
            }

            if (Core.Create.UniqueReference(antenna_2) is not IUniqueReference uniqueReference_2)
            {
                return null;
            }

            List<ScatteringProfileAntennasRelation>? scatteringProfileAntennasRelations = GetRelations<ScatteringProfileAntennasRelation>(Core.Create.UniqueReference(scatteringProfile), x => x?.UniqueReferences_To is List<IUniqueReference> uniqueReferences && uniqueReferences.Contains(uniqueReference_1) && uniqueReferences.Contains(uniqueReference_2));
            if (scatteringProfileAntennasRelations != null)
            {
                foreach (ScatteringProfileAntennasRelation scatteringAntennasRelation in scatteringProfileAntennasRelations)
                {
                    Remove(scatteringAntennasRelation);
                }
            }

            return AddRelation(new ScatteringProfileAntennasRelation(scatteringProfile, antenna_1, antenna_2));
        }

        /// <summary>
        /// Adds a relation between the specified scattering profile and multipath power delay profile.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to associate.</param>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile to associate.</param>
        /// <returns>A <see cref="ScatteringProfileMultipathPowerDelayProfileRelation"/> if the relation was successfully added; otherwise, <c>null</c> if either parameter is null.</returns>
        public ScatteringProfileMultipathPowerDelayProfileRelation? AddRelation(IScatteringProfile? scatteringProfile, IMultipathPowerDelayProfile? multipathPowerDelayProfile)
        {
            if (scatteringProfile == null || multipathPowerDelayProfile == null)
            {
                return null;
            }

            IUniqueReference? uniqueReference = Core.Create.UniqueReference(multipathPowerDelayProfile);

            List<ScatteringProfileMultipathPowerDelayProfileRelation>? scatteringProfileMultipathPowerDelayProfileRelations = GetRelations<ScatteringProfileMultipathPowerDelayProfileRelation>(Core.Create.UniqueReference(scatteringProfile), x => x?.UniqueReference_To?.ToString() == uniqueReference?.ToString());
            if (scatteringProfileMultipathPowerDelayProfileRelations != null)
            {
                foreach (ScatteringProfileMultipathPowerDelayProfileRelation scatteringProfileMultipathPowerDelayProfileRelation in scatteringProfileMultipathPowerDelayProfileRelations)
                {
                    Remove(scatteringProfileMultipathPowerDelayProfileRelation);
                }
            }

            return AddRelation(new ScatteringProfileMultipathPowerDelayProfileRelation(scatteringProfile, multipathPowerDelayProfile));
        }

        /// <summary>
        /// Adds a relation between the specified angular power distribution profile and antenna.
        /// </summary>
        /// <param name="angularPowerDistributionProfile">The angular power distribution profile to associate.</param>
        /// <param name="antenna">The antenna to associate.</param>
        /// <returns>A new <see cref="AngularPowerDistributionProfileAntennaRelation"/> if both parameters are non-null; otherwise, null.</returns>
        public AngularPowerDistributionProfileAntennaRelation? AddRelation(IAngularPowerDistributionProfile? angularPowerDistributionProfile, IAntenna? antenna)
        {
            if (angularPowerDistributionProfile == null || antenna == null)
            {
                return null;
            }

            IUniqueReference? uniqueReference = Core.Create.UniqueReference(antenna);

            AngularPowerDistributionProfileAntennaRelation? multipathPowerDelayProfileAntennasRelation = GetRelation<AngularPowerDistributionProfileAntennaRelation>(Core.Create.UniqueReference(angularPowerDistributionProfile), x => x?.UniqueReference_To?.ToString() == uniqueReference?.ToString());
            if (multipathPowerDelayProfileAntennasRelation != null)
            {
                Remove(multipathPowerDelayProfileAntennasRelation);
            }

            return AddRelation(new AngularPowerDistributionProfileAntennaRelation(angularPowerDistributionProfile, antenna));
        }

        /// <summary>
        /// Adds a relation between the specified scattering group and its scattering objects, replacing any existing relation for that group.
        /// </summary>
        /// <param name="scatteringGroup">The scattering group to associate.</param>
        /// <param name="scatteringObjects">The scattering objects to associate with the scattering group.</param>
        /// <returns>The created <see cref="ScatteringGroupScatteringObjectsRelation"/> if successful; otherwise, <c>null</c>.</returns>
        public ScatteringGroupScatteringObjectsRelation? AddRelation(IScatteringGroup? scatteringGroup, IEnumerable<IScatteringObject>? scatteringObjects)
        {
            if (scatteringGroup == null || scatteringObjects == null)
            {
                return null;
            }

            ScatteringGroupScatteringObjectsRelation? scatteringGroupScatteringObjectsRelation = GetRelation<ScatteringGroupScatteringObjectsRelation>(Core.Create.UniqueReference(scatteringGroup));
            if (scatteringGroupScatteringObjectsRelation != null)
            {
                Remove(scatteringGroupScatteringObjectsRelation);
            }

            return AddRelation(new ScatteringGroupScatteringObjectsRelation(scatteringGroup, scatteringObjects));
        }
    }
}