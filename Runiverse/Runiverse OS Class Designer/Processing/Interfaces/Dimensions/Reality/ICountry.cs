namespace RuniOS.Processing.Interfaces.Dimensions.Reality
{
    /// <summary>
    /// 프로세스가 지구의 특정 국가에 속해있을 때 상속되는 인터페이스입니다.
    /// </summary>
    public interface ICountry : IEarth
    {
        /// <summary>
        /// 속해있는 국가의 이름입니다.
        /// </summary>
        string countryName { get; }
    }
}
