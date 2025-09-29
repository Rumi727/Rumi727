namespace RuniOS.Processing
{
    public interface IGalaxy : IUniverse
    {
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigVector2 galaxyPosition { get; set; }
    }
}
