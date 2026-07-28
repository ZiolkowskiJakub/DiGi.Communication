using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a spherical distribution collection of scattering hits partitioned into azimuth and elevation bins.
    /// </summary>
    /// <typeparam name="TScatteringHit">The type of scattering hit stored in the collection.</typeparam>
    public class SphericalDistributionScatteringHitCollection<TScatteringHit> : SphericalDistributionSerializableObjectCollection<TScatteringHit>, ICommunicationSerializableObject where TScatteringHit : IScatteringHit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionScatteringHitCollection{TScatteringHit}"/> class.
        /// </summary>
        public SphericalDistributionScatteringHitCollection()
            : base(new Range<double>(0, System.Math.PI * 2), System.Math.PI / 360 , new Range<double>(0, System.Math.PI * 2), System.Math.PI / 360)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionScatteringHitCollection{TScatteringHit}"/> class by copying another collection.
        /// </summary>
        /// <param name="sphericalDistributionCollection">The collection to copy from.</param>
        public SphericalDistributionScatteringHitCollection(SphericalDistributionScatteringHitCollection<TScatteringHit>? sphericalDistributionCollection)
            : base(sphericalDistributionCollection)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionScatteringHitCollection{TScatteringHit}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public SphericalDistributionScatteringHitCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>
    /// Non-generic version of <see cref="SphericalDistributionScatteringHitCollection{TScatteringHit}"/> for handling a collection of <see cref="IScatteringHit"/> objects.
    /// </summary>
    public class SphericalDistributionScatteringHitCollection : SphericalDistributionScatteringHitCollection<IScatteringHit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionScatteringHitCollection"/> class.
        /// </summary>
        public SphericalDistributionScatteringHitCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionScatteringHitCollection"/> class by copying another collection.
        /// </summary>
        /// <param name="sphericalDistributionCollection">The collection to copy from.</param>
        public SphericalDistributionScatteringHitCollection(SphericalDistributionScatteringHitCollection? sphericalDistributionCollection)
            : base(sphericalDistributionCollection)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionScatteringHitCollection"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public SphericalDistributionScatteringHitCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}
