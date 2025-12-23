using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class SimpleMultipathPowerDelayProfile : GuidObject, ISimpleMultipathPowerDelayProfile
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly SortedDictionary<double, double>? values;

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

        public SimpleMultipathPowerDelayProfile(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

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
