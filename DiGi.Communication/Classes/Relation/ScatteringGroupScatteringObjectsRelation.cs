using DiGi.Communication.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a directional one-to-many relationship between a scattering group and its associated scattering objects.
    /// </summary>
    public class ScatteringGroupScatteringObjectsRelation : OneToManyDirectionalRelation<IScatteringGroup, IScatteringObject>, ICommunicationRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringGroupScatteringObjectsRelation"/> class.
        /// </summary>
        /// <param name="scatteringGroup">The scattering group to be associated in the relation.</param>
        /// <param name="scatteringObjects">The collection of scattering objects to be associated with the group.</param>
        public ScatteringGroupScatteringObjectsRelation(IScatteringGroup? scatteringGroup, IEnumerable<IScatteringObject> scatteringObjects)
            : base(scatteringGroup, scatteringObjects)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringGroupScatteringObjectsRelation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data for the relation.</param>
        public ScatteringGroupScatteringObjectsRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringGroupScatteringObjectsRelation"/> class by copying an existing relation.
        /// </summary>
        /// <param name="scatteringGroupScatteringObjectsRelation">The source relation to copy from, or <see langword="null"/> to create a default instance.</param>
        public ScatteringGroupScatteringObjectsRelation(ScatteringGroupScatteringObjectsRelation? scatteringGroupScatteringObjectsRelation)
            : base(scatteringGroupScatteringObjectsRelation)
        {
        }
    }
}