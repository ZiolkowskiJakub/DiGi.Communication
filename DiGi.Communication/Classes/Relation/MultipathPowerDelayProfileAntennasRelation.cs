using DiGi.Communication.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a bidirectional one-to-many relationship between a multipath power delay profile and its associated antennas.
    /// </summary>
    public class MultipathPowerDelayProfileAntennasRelation : OneToManyBidirectionalRelation<IMultipathPowerDelayProfile, IAntenna>, ICommunicationRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipathPowerDelayProfileAntennasRelation"/> class.
        /// </summary>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile associated with this relation.</param>
        /// <param name="antenna_1">The first antenna associated with this relation.</param>
        /// <param name="antenna_2">The second antenna associated with this relation.</param>
        public MultipathPowerDelayProfileAntennasRelation(IMultipathPowerDelayProfile multipathPowerDelayProfile, IAntenna antenna_1, IAntenna antenna_2)
            : base(multipathPowerDelayProfile, [antenna_1, antenna_2])
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipathPowerDelayProfileAntennasRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the relation.</param>
        public MultipathPowerDelayProfileAntennasRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipathPowerDelayProfileAntennasRelation"/> class using an existing instance.
        /// </summary>
        /// <param name="multipathPowerDelayProfileAntennasRelation">The source relation instance to copy from.</param>
        public MultipathPowerDelayProfileAntennasRelation(MultipathPowerDelayProfileAntennasRelation multipathPowerDelayProfileAntennasRelation)
            : base(multipathPowerDelayProfileAntennasRelation)
        {
        }
    }
}