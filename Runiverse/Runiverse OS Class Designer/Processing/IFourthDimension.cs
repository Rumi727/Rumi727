namespace RuniOS.Processing
{
    public interface IFourthDimension : IDimension
    {
        BigTimeSpan time { get; }
        BigVector3 position { get; set; }
    }
}
