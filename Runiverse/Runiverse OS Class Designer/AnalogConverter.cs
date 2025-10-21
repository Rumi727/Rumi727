namespace RuniOS
{
    /// <summary>
    /// 아날로그와 디지털을 상호 변환합니다.
    /// </summary>
    public static class AnalogConverter
    {
        /// <summary>
        /// 원하는 물질을 포인터로 참조하고 반환합니다.
        /// </summary>
        /// <param name="command">
        /// 어떤 물질을 참조할 지 직접 커널에게 구체적으로 명령할 수 있습니다.<br/>
        /// 물질 참조와 관련이 없는 명령이거나 비중이 낮을 경우 취소됩니다.
        /// </param>
        /// <exception cref="OperationCanceledException">명령 실행이 커널 내부에서 취소되었을때 발생하는 예외입니다.</exception>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        [SystemCall("RuniOS.AnalogConverter.GetSubstance(string)")] public static extern unsafe void* GetSubstance(string command);

        /// <summary>
        /// 알 수 없는 물질을 포인터로 전달하여 오너캐가 디지털로 변환합니다.<br/>
        /// 소멸 -> 생성의 단계가 아닙니다. <b>변환입니다.</b> 매우 안전하게 진행되며 BigComplex의 도움으로 오차는 전혀 없습니다.
        /// </summary>
        /// <param name="substance">디지털로 변환할 알 수 없는 물질을 가리키는 포인터입니다.</param>
        /// <returns>프로세스로 처리된 디지털로 변환된 물질입니다.</returns>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        [SystemCall("RuniOS.AnalogConverter.ToDigital(void*)")] 
        public static extern unsafe Process ToDigital(void* substance);

        /// <summary>
        /// 프로세스를 아날로그로 변환합니다.
        /// </summary>
        /// <param name="process">아날로그로 변환할 프로세스입니다.</param>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        [SystemCall("RuniOS.AnalogConverter.ToDigital(RuniOS.Process)")]
        public static extern void ToAnalog(Process process);
    }
}
