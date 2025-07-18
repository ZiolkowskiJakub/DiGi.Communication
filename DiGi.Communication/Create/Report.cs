using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Core.IO.Classes;

namespace DiGi.Communication
{
    public static partial class Create
    {
        public static Report Report(this GeometricalPropagationModel geometricalPropagationModel)
        {
            Report result = new Report();

            if (geometricalPropagationModel == null)
            {
                return result;
            }

            List<IAntenna> antennas = geometricalPropagationModel.GetAntennas<IAntenna>();
            List<ISimpleMultipathPowerDelayProfile> simpleMultipathPowerDelayProfiles = geometricalPropagationModel.GetMultipathPowerDelayProfiles<ISimpleMultipathPowerDelayProfile>();
            List<IComplexMultipathPowerDelayProfile> complexMultipathPowerDelayProfiles = geometricalPropagationModel.GetMultipathPowerDelayProfiles<IComplexMultipathPowerDelayProfile>();
            List<IScatteringProfile> scatteringProfiles = geometricalPropagationModel.GetScatteringProfiles<IScatteringProfile>();
            List<IAngularPowerDistributionProfile> angularPowerDistributionProfiles = geometricalPropagationModel.GetAngularPowerDistributionProfiles<IAngularPowerDistributionProfile>();
            List<IScatteringObject> scatteringObjects = geometricalPropagationModel.GetScatteringObjects<IScatteringObject>();

            result.Add("GeometricalPropagationModel");
            result.Add("Guid", "Antennas", "SimpleMultipathPowerDelayProfiles", "ComplexMultipathPowerDelayProfiles", "ScatteringProfiles", "AngularPowerDistributionProfiles", "ScatteringObjects");
            result.Add(geometricalPropagationModel.Guid, antennas?.Count, simpleMultipathPowerDelayProfiles?.Count, complexMultipathPowerDelayProfiles?.Count, scatteringProfiles?.Count, angularPowerDistributionProfiles?.Count, scatteringObjects?.Count);
            result.Add();

            if (antennas != null && antennas.Count != 0)
            {
                result.Add("Antennas");
                result.Add("Guid", "X", "Y", "Z", "Functions");
                foreach (IAntenna antenna in antennas)
                {
                    result.Add<object>(antenna?.Guid, antenna?.Location?.X, antenna?.Location?.Y, antenna?.Location?.Z, antenna?.Functions?.ToList().ConvertAll(x => Core.Query.Description(x)));
                }
                result.Add();
            }

            Action<ISimpleMultipathPowerDelayProfile> append = new Action<ISimpleMultipathPowerDelayProfile>( x =>
            {
                result.Add(x?.Guid);

                HashSet<double> delays = x?.Delays;
                if (delays == null)
                {
                    return;
                }

                result.Add("Delay", "Power");
                foreach (double delay in delays)
                {
                    result.Add(delay, x.GetPower(delay));
                }
            });

            if (simpleMultipathPowerDelayProfiles != null && simpleMultipathPowerDelayProfiles.Count != 0)
            {
                result.Add("SimpleMultipathPowerDelayProfiles");
                foreach (ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile in simpleMultipathPowerDelayProfiles)
                {
                    append(simpleMultipathPowerDelayProfile);
                    result.Add();
                }
            }

            if (complexMultipathPowerDelayProfiles != null && complexMultipathPowerDelayProfiles.Count != 0)
            {
                result.Add("ComplexMultipathPowerDelayProfiles");
                foreach (IComplexMultipathPowerDelayProfile complexMultipathPowerDelayProfile in complexMultipathPowerDelayProfiles)
                {
                    result.Add("Guid");
                    result.Add(complexMultipathPowerDelayProfile.Guid);
                    result.Add("Visible");
                    append(complexMultipathPowerDelayProfile?.GetSimpleMultipathPowerDelay(true));
                    result.Add("Hidden");
                    append(complexMultipathPowerDelayProfile?.GetSimpleMultipathPowerDelay(false));
                    result.Add();
                }
            }

            if(scatteringProfiles != null && scatteringProfiles.Count != 0)
            {
                result.Add("ScatteringProfiles");
                result.Add("Guid", "Visible", "X 1", "Y 1", "Z 1", "X 2", "Y 2", "Z 2");
                foreach (IScatteringProfile scatteringProfile in scatteringProfiles)
                {
                    result.Add(scatteringProfile.Guid, scatteringProfile.Visible, scatteringProfile.Location_1.X, scatteringProfile.Location_1.Y, scatteringProfile.Location_1.Z);
                }
            }

            return result;

        }

    }
}
