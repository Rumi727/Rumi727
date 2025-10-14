namespace RuniOS.Processing.Interfaces.Dimensions.Reality
{
    /// <summary>
    /// 프로세스가 인터넷에 속해있을 때 상속되는 인터페이스 입니다.
    /// </summary>
    public interface IInternet
    {
        /// <summary>
        /// 연결된 인터넷 지원 장치 중에 가장 가까운 장치입니다.
        /// </summary>
        Process? linkedDevice { get; }

        /// <summary>
        /// 연결된 서버 목록입니다.
        /// </summary>
        IReadOnlyList<Process> linkedServers { get; }

        /// <summary>
        /// 메인으로 통신 중인 서버입니다.
        /// </summary>
        Process? currentServer { get; }
    }
}
