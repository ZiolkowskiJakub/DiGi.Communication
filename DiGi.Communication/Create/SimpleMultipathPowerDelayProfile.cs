using DiGi.Communication.Classes;

namespace DiGi.Communication
{
    public static partial class Create
    {
        public static SimpleMultipathPowerDelayProfile SimpleMultipathPowerDelayProfile(Enums.DefaultSimpleMultipathPowerDelayProfile defaultSimpleMultipathPowerDelayProfile)
        {
            switch(defaultSimpleMultipathPowerDelayProfile)
            {
                case Enums.DefaultSimpleMultipathPowerDelayProfile.BadUrban:
                    return new SimpleMultipathPowerDelayProfile(new Dictionary<double, double>
                    {
                        { 0.0, 0.033 },
                        { 0.1e-6, 0.089 },
                        { 0.3e-6, 0.141 },
                        { 0.7e-6, 0.194 },
                        { 1.6e-6, 0.114 },
                        { 2.2e-6, 0.052 },
                        { 3.1e-6, 0.035 },
                        { 5.0e-6, 0.140 },
                        { 6.0e-6, 0.136 },
                        { 7.2e-6, 0.041 },
                        { 8.1e-6, 0.019 },
                        { 10.0e-6, 0.006 },
                    });

                case Enums.DefaultSimpleMultipathPowerDelayProfile.TypicalUrban:
                    return new SimpleMultipathPowerDelayProfile(new Dictionary<double, double>
                    {
                        { 0.0, 0.092 },
                        { 0.1e-6, 0.115 },
                        { 0.3e-6, 0.231 },
                        { 0.5e-6, 0.127 },
                        { 0.8e-6, 0.115 },
                        { 1.1e-6, 0.074 },
                        { 1.3e-6, 0.046 },
                        { 1.7e-6, 0.074 },
                        { 2.3e-6, 0.051 },
                        { 3.1e-6, 0.032 },
                        { 3.2e-6, 0.018 },
                        { 5.0e-6, 0.025 },
                    });
            }

            return null;
        }

    }
}
