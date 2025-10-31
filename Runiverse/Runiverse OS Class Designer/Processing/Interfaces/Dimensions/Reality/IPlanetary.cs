namespace RuniOS.Processing.Interfaces.Dimensions.Reality
{
    /// <summary>
    /// 프로세스가 특정한 행성에 속해있을 때 상속되는 인터페이스입니다.
    /// </summary>
    public interface IPlanetary : IHeavenlyBody
    {
        BigDateTime orbitalPeriod { get; }
        BigQuaternion centralAxis { get; }
    }
}
