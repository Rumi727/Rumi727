namespace RuniOS.Processing.Interfaces.Dimensions.Reality
{
    /// <summary>
    /// 프로세스가 태양계에 속해있을 때 상속되는 인터페이스 입니다.
    /// </summary>
    public interface ISolarSystem : IGalaxy
    {
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigVector2 solarSystemPosition { get; set; }
    }
}
