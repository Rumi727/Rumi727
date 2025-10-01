namespace RuniOS.Processing.Interfaces.Creatures
{
    /// <summary>
    /// 프로세스가 일반적인 상식으로 동물로써 분류되는 생명체일 시 상속되는 인터페이스 입니다.
    /// </summary>
    public interface IAnimal : ICreature
    {
        /// <summary>
        /// 생명체의 생물학적 성별입니다.
        /// </summary>
        BiologicalSex biologicalSex { get; }

        /// <summary>
        /// 생명체의 생물학적 성별 및 정서적 성별을 전환할 수 있습니다.
        /// </summary>
        /// <param name="command">
        /// 어떤식으로 성별을 변경할 지 직접 커널에게 구체적으로 명령할 수 있습니다.<br/>
        /// 성전환과 관련이 없는 명령이거나 비중이 낮을 경우 취소됩니다.
        /// </param>
        /// <exception cref="OperationCanceledException">명령 실행이 커널 내부에서 취소되었을때 발생하는 예외입니다.</exception>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        [SystemCall("RuniOS.Processing.IAnimal.SexChange(string)")] extern void SexChange(string command);
    }
}
