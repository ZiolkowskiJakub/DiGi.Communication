using DiGi.Communication.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    public class ComplexMultipathPowerDelayProfile : GuidObject, IComplexMultipathPowerDelayProfile
    {
        [JsonInclude, JsonPropertyName("SimpleMultipathPowerDelayProfile_Hidden")]
        private ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile_Hidden;

        [JsonInclude, JsonPropertyName("SimpleMultipathPowerDelayProfile_Visible")]
        private ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile_Visible;
        public ComplexMultipathPowerDelayProfile(Guid guid, ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile_Visible, ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile_Hidden)
            : base(guid)
        {
            this.simpleMultipathPowerDelayProfile_Visible = Core.Query.Clone(simpleMultipathPowerDelayProfile_Visible);
            this.simpleMultipathPowerDelayProfile_Hidden = Core.Query.Clone(simpleMultipathPowerDelayProfile_Hidden);
        }

        public ComplexMultipathPowerDelayProfile(ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile_Visible, ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile_Hidden)
            : base()
        {
            this.simpleMultipathPowerDelayProfile_Visible = Core.Query.Clone(simpleMultipathPowerDelayProfile_Visible);
            this.simpleMultipathPowerDelayProfile_Hidden = Core.Query.Clone(simpleMultipathPowerDelayProfile_Hidden);
        }

        public ComplexMultipathPowerDelayProfile(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ComplexMultipathPowerDelayProfile(ComplexMultipathPowerDelayProfile complexMultipathPowerDelayProfile)
            : base(complexMultipathPowerDelayProfile)
        {
            if (complexMultipathPowerDelayProfile != null)
            {
                simpleMultipathPowerDelayProfile_Visible = Core.Query.Clone(complexMultipathPowerDelayProfile.simpleMultipathPowerDelayProfile_Visible);
                simpleMultipathPowerDelayProfile_Hidden = Core.Query.Clone(complexMultipathPowerDelayProfile.simpleMultipathPowerDelayProfile_Hidden);
            }
        }

        public ISimpleMultipathPowerDelayProfile GetSimpleMultipathPowerDelay(bool visible)
        {
            return visible ? Core.Query.Clone(simpleMultipathPowerDelayProfile_Visible) : Core.Query.Clone(simpleMultipathPowerDelayProfile_Hidden);
        }
    }
}
