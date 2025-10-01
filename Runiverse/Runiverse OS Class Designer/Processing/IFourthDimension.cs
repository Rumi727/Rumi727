namespace RuniOS.Processing
{
    public interface IFourthDimension : IDimension
    {
        /// <summary>
        /// 물질의 현재 절대 시간입니다. 물질마다 다를 수 있습니다. (단위: 초)
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
