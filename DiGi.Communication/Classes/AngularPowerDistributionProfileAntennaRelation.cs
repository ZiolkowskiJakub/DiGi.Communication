using DiGi.Communication.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a one-to-one directional relationship between an angular power distribution profile and an antenna.
    /// </summary>
    public class AngularPowerDistributionProfileAntennaRelation : OneToOneDirectionalRelation<IAngularPowerDistributionProfile, IAntenna>, ICommunicationRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistributionProfileAntennaRelation"/> class.
        /// </summary>
        /// <param name="angularPowerDistributionProfile">The angular power distribution profile to be associated.</param>
        /// <param name="antenna">The antenna to be associated.</param>
        public AngularPowerDistributionProfileAntennaRelation(IAngularPowerDistributionProfile angularPowerDistributionProfile, IAntenna antenna)
            : base(angularPowerDistributionProfile, antenna)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistributionProfileAntennaRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the relation.</param>
        public AngularPowerDistributionProfileAntennaRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistributionProfileAntennaRelation"/> class based on an existing instance.
        /// </summary>
        /// <param name="angularPowerDistributionProfileAntennaRelation">The existing <see cref="AngularPowerDistributionProfileAntennaRelation"/> instance to copy from.</param>
        public AngularPowerDistributionProfileAntennaRelation(AngularPowerDistributionProfileAntennaRelation angularPowerDistributionProfileAntennaRelation)
            : base(angularPowerDistributionProfileAntennaRelation)
        {
        }
    }
}