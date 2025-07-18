namespace DiGi.Communication.Interfaces
{
    public interface IComplexMultipathPowerDelayProfile : IMultipathPowerDelayProfile
    {
        ISimpleMultipathPowerDelayProfile GetSimpleMultipathPowerDelay(bool visible);
    }
}
