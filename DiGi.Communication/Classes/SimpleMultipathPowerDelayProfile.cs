using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents a simple multipath power delay profile that maps specific time delays to their corresponding power levels.
    /// </summary>
    public class SimpleMultipathPowerDelayProfile : GuidObject, ISimpleMultipathPowerDelayProfile
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly SortedDictionary<double, double>? values;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleMultipathPowerDelayProfile"/> class.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <param name="values">The data matrix for interpolation, in [y, x] format.</param>
        public SimpleMultipathPowerDelayProfile(Guid guid, IEnumerable<KeyValuePair<double, double>>? values)
            : base(guid)
        {
            if (values != null)
            {
                this.values = [];
                foreach (KeyValuePair<double, double> keyValuePair in values)
                {
                    this.values[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleMultipathPowerDelayProfile"/> class.
        /// </summary>
        /// <param name="values">The data matrix for interpolation, in [y, x] format.</param>
        public SimpleMultipathPowerDelayProfile(IEnumerable<KeyValuePair<double, double>>? values)
            : base()
        {
            if (values != null)
            {
                this.values = [];
                foreach (KeyValuePair<double, double> keyValuePair in values)
                {
                    this.values[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleMultipathPowerDelayProfile"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the current instance.</param>
        public SimpleMultipathPowerDelayProfile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleMultipathPowerDelayProfile"/> class using an existing <see cref="SimpleMultipathPowerDelayProfile"/> object.
        /// </summary>
        /// <param name="simpleMultipathPowerDelayProfile">The source <see cref="SimpleMultipathPowerDelayProfile"/> object to copy data from.</param>
        public SimpleMultipathPowerDelayProfile(SimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile)
            : base(simpleMultipathPowerDelayProfile)
        {
            if (simpleMultipathPowerDelayProfile != null)
            {
                if (simpleMultipathPowerDelayProfile.values != null)
                {
                    values = [];
                    foreach (KeyValuePair<double, double> keyValuePair in simpleMultipathPowerDelayProfile.values)
                    {
                        values[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Delays [s]
        /// </summary>
        [JsonIgnore]
        public HashSet<double>? Delays
        {
            get
            {
                if (values == null)
                {
                    return null;
                }

                return [.. values.Keys];
            }
        }

        /// <summary>
        /// Gets the power value associated with the specified delay.
        /// </summary>
        /// <param name="delay">The delay for which to retrieve the power.</param>
        /// <returns>The power value corresponding to the given delay, or <see cref="double.NaN"/> if the values are not initialized or the delay is not found.</returns>
        public double GetPower(double delay)
        {
            if (values == null)
            {
                return double.NaN;
            }

            if (!values.TryGetValue(delay, out double result))
            {
                result = double.NaN;
            }

            return result;
        }
    }
}