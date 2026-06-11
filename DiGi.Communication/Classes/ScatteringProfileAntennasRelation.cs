using DiGi.Communication.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a directional one-to-many relationship between a scattering profile and its associated antennas.
    /// </summary>
    public class ScatteringProfileAntennasRelation : OneToManyDirectionalRelation<IScatteringProfile, IAntenna>, ICommunicationRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringProfileAntennasRelation"/> class.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile associated with this relation.</param>
        /// <param name="antenna_1">The first antenna to be associated with the scattering profile.</param>
        /// <param name="antenna_2">The second antenna to be associated with the scattering profile.</param>
        public ScatteringProfileAntennasRelation(IScatteringProfile? scatteringProfile, IAntenna? antenna_1, IAntenna? antenna_2)
            : base(scatteringProfile, Core.Query.FilterNulls([antenna_1, antenna_2]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringProfileAntennasRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the relation, or <see langword="null"/>.</param>
        public ScatteringProfileAntennasRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringProfileAntennasRelation"/> class.
        /// </summary>
        /// <param name="scatteringProfileAntennasRelation">The existing relation to copy from, or null to create a new one.</param>
        public ScatteringProfileAntennasRelation(ScatteringProfileAntennasRelation? scatteringProfileAntennasRelation)
            : base(scatteringProfileAntennasRelation)
        {
        }
    }
}