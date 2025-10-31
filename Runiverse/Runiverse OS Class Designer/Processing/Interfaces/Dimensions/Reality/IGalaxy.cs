namespace RuniOS.Processing.Interfaces.Dimensions.Reality
{
    /// <summary>
    /// 프로세스가 현실의 특정한 은하에 속해있을 때 상속되는 인터페이스입니다.
    /// </summary>
    public interface IGalaxy : IHeavenlyBody
    {
        /// <summary>
        /// 인터페이스가 참조하고 있는 물질이 속한 은하의 중심 절대 좌표입니다.
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigVector2 galaxyPosition { get; set; }
    }
}
