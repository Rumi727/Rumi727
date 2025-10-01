namespace RuniOS.Processing.Interfaces.Dimensions
{
    /// <summary>
    /// 프로세스가 단순한 3차원 박스 물리를 가지고 있을 때 상속되는 인터페이스 입니다.
    /// </summary>
    public interface IBoxPhysics : IFourthDimension, IPhysics
    {
        BigVector3 colliderSize { get; }
        BigVector3 colliderOffset { get; }
    }
}
