namespace RuniOS.Processing
{
    public interface IRealPhysics : IFourthDimension, IPhysics
    {
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigVector3 velocity { get; set; }

        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigComplex mass { get; set; }

        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigComplex temperature { get; set; }
    }
}
