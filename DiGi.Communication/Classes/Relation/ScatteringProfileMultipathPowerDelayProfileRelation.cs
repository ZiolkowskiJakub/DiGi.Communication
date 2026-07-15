using DiGi.Communication.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a one-to-one bidirectional relationship between a scattering profile and a multipath power delay profile.
    /// </summary>
    public class ScatteringProfileMultipathPowerDelayProfileRelation : OneToOneBidirectionalRelation<IScatteringProfile, IMultipathPowerDelayProfile>, ICommunicationRelation
    {
        /// <summary> Initializes a new instance of the <see cref="ScatteringProfileMultipathPowerDelayProfileRelation" /> class. </summary>
        /// <param name="scatteringProfile">The scattering profile to be associated in the relation.</param>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile to be associated in the relation.</param>
        public ScatteringProfileMultipathPowerDelayProfileRelation(IScatteringProfile scatteringProfile, IMultipathPowerDelayProfile multipathPowerDelayProfile)
            : base(scatteringProfile, multipathPowerDelayProfile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringProfileMultipathPowerDelayProfileRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the relation.</param>
        public ScatteringProfileMultipathPowerDelayProfileRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringProfileMultipathPowerDelayProfileRelation"/> class using an existing relation instance.
        /// </summary>
        /// <param name="scatteringProfileMultipathPowerDelayProfileRelation">The existing <see cref="ScatteringProfileMultipathPowerDelayProfileRelation"/> instance to copy from.</param>
        public ScatteringProfileMultipathPowerDelayProfileRelation(ScatteringProfileMultipathPowerDelayProfileRelation scatteringProfileMultipathPowerDelayProfileRelation)
            : base(scatteringProfileMultipathPowerDelayProfileRelation)
        {
        }
    }
}
