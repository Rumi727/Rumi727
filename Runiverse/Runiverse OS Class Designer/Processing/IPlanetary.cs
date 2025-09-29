namespace RuniOS.Processing
{
    public interface IPlanetary : IUniverse
    {
        BigDateTime orbitalPeriod { get; set; }
        BigQuaternion centralAxis { get; set; }
    }
}
