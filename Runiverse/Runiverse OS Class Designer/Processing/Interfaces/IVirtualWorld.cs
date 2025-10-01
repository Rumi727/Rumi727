namespace RuniOS.Processing.Interfaces
{
    /// <summary>
    /// 프로세스가 가상 세계에 속해있을 때 상속되는 인터페이스 입니다.
    /// </summary>
    public interface IVirtualWorld
    {
        /// <summary>
        /// 가상 세계의 애플리케이션 이름입니다.
        /// </summary>
        string applicationName { get; }

        /// <summary>
        /// 가상 세계의 애플리케이션 버전입니다.
        /// </summary>
        Version applicationVersion { get; }
    }
}
