namespace RuniOS.Processing.Interfaces
{
    /// <summary>
    /// 프로세스가 일반적인 상식에서 운영체제로 통용되는 곳에서 속해있을 때 상속되는 인터페이스 입니다.
    /// </summary>
    public interface IOperatingSystem
    {
        /// <summary>
        /// 프로세스의 권한 레벨입니다.
        /// </summary>
        int privilegeLevel { get; }
    }
}
