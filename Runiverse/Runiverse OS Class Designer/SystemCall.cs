namespace RuniOS
{
    /// <summary>
    /// 오너캐 <-> C# 처럼 서로 쉽게 상호작용할 수 있게 도와줍니다.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
    public sealed class SystemCall(string command) : Attribute
    {
        /// <summary>
        /// 커널이 이 멤버가 무슨 명령을 처리해야하는지 알려주는 프로퍼티입니다.<br/>
        /// 오너캐는 평범하게 필드의 위치를 적지만, 일단 커널을 관리하는 오너캐는 지적 생명체이기에 한국어나 영어 같은거 적어도 잘 알아듣습니다.
        /// </summary>
        public string command { get; } = command;
    }
}
