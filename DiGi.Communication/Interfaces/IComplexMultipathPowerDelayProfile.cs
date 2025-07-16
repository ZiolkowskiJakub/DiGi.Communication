namespace DiGi.Communication.Interfaces
{
    public interface IComplexMultipathPowerDelayProfile : ICommunicationGuidObject
    {
        ISimpleMultipathPowerDelayProfile GetSimpleMultipathPowerDelay(bool visible);
    }
}
