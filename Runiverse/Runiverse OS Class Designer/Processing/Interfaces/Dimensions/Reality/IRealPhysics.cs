using RuniOS.Processing.Interfaces.Dimensions;

namespace RuniOS.Processing.Interfaces.Dimensions.Reality
{
    /// <summary>
    /// 현실의 물리 법칙을 따르는 프로세스일 때 상속되는 인터페이스 입니다.
    /// </summary>
    public interface IRealPhysics : IFourthDimension, IPhysics
    {
        /// <summary>
        /// 이 인터페이스가 참조하는 전체 물질의 총 질량입니다. (단위: 그램)
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigComplex mass { get; set; }

        /// <summary>
        /// 이 인터페이스가 참조하는 전체 물질의 평균 온도입니다. (단위: 섭씨)
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        BigComplex temperature { get; set; }
    }
}
