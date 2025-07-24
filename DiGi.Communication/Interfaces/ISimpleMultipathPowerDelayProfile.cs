namespace DiGi.Communication.Interfaces
{
    public interface ISimpleMultipathPowerDelayProfile : IMultipathPowerDelayProfile
    {
        HashSet<double> Delays { get; }

        double GetPower(double delay);
    }
}
