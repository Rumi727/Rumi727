namespace RuniOS.Processing
{
    public interface IGalaxy : IUniverse
    {
        /// <summary>
        /// 인터페이스가 참조하고 있는 물질이 속한 은하의 중심 절대 좌표입니다.
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigVector2 galaxyPosition { get; set; }
    }
}
