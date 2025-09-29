namespace RuniOS.Processing
{
    public interface IPlanetary : IUniverse
    {
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigDateTime orbitalPeriod { get; set; }

        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigQuaternion centralAxis { get; set; }
    }
}
