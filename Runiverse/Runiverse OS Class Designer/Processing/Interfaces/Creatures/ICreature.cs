namespace RuniOS.Processing.Interfaces.Creatures
{
    /// <summary>
    /// 프로세스가 생명체일 때 상속되는 인터페이스 입니다.
    /// </summary>
    public interface ICreature
    {
        /// <summary>
        /// 일반적인 상식에서 통용되는 생명체의 이름입니다.<br/>
        /// 프로퍼티 호출자마다 값이 다를 수 있습니다.
        /// </summary>
        string name { get; }

        /// <summary>
        /// 생명체가 만들어진 날짜입니다.
        /// </summary>
        BigDateTime birthday { get; }

        /// <summary>
        /// 생명체의 나이입니다.
        /// </summary>
        BigComplex age { get; }
    }
}
