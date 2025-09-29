namespace RuniOS.Processing
{
    public interface IFourthDimension : IDimension
    {
        BigTimeSpan time { get; }

        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigVector3 position { get; set; }
    }
}
