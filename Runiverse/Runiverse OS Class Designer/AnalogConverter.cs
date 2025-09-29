namespace RuniOS
{
    /// <summary>
    /// 아날로그와 디지털을 상호 변환합니다.
    /// </summary>
    public static class AnalogConverter
    {
        /// <summary>
        /// 알 수 없는 물질을 포인터로 전달하여 오너캐가 디지털로 변환합니다.<br/>
        /// 소멸 -> 생성의 단계가 아닙니다. **변환입니다.**, 매우 안전하게 진행되며 BigComplex의 도움으로 오차는 전혀 없습니다.
        /// </summary>
        /// <param name="substance">디지털로 변환할 알 수 없는 물질을 가리키는 포인터입니다.</param>
        /// <returns>프로세스로 처리된 디지털로 변환된 물질입니다.</returns>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        [SystemCall("RuniOS.AnalogConverter.ToDigital(void*)")] 
        public static extern unsafe Process ToDigital(void* substance);

        /// <summary>
        /// 프로세스를 다시 아날로그로 변환합니다.
        /// </summary>
        /// <param name="process">아날로그로 변환할 프로세스입니다.</param>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        [SystemCall("RuniOS.AnalogConverter.ToDigital")]
        public static extern unsafe void ToAnalog(Process process);
    }
}
