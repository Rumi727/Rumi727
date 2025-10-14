namespace RuniOS.Processing.Interfaces.Programs
{
    /// <summary>
    /// 프로세스가 프로그램일 때 상속되는 인터페이스입니다.
    /// </summary>
    public interface IProgram : IOperatingSystem
    {
        /// <summary>
        /// 애플리케이션 이름입니다.
        /// </summary>
        string applicationName { get; }

        /// <summary>
        /// 애플리케이션 버전입니다.
        /// </summary>
        Version applicationVersion { get; }
    }
}
