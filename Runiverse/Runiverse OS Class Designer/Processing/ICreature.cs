namespace RuniOS.Processing
{
    /// <summary>
    /// 프로세스가 생명체일 때 상속되는 인터페이스 입니다.
    /// </summary>
    public interface ICreature
    {
        string name { get; }
        BigDateTime birthday { get; }
    }
}
