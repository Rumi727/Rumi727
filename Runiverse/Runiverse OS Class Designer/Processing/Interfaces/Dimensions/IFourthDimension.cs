namespace RuniOS.Processing.Interfaces.Dimensions
{
    /// <summary>
    /// 프로세스가 시간과 3차원 축이 있는 차원에 속해 있을 때 상속되는 인터페이스 입니다.
    /// </summary>
    public interface IFourthDimension : IDimension
    {
        /// <summary>
        /// 물질이 속해 있는 차원의 현재 절대 시간입니다. (단위: 초)
        /// </summary>
        BigTimeSpan time { get; }

        /// <summary>
        /// 물질의 현재 절대 좌표입니다. (단위: 미터)
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigVector3 position { get; set; }

        /// <summary>
        /// 물질이 현재 1초당 이동하는 값입니다.
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigVector3 velocity { get; set; }
    }
}
