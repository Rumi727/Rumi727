namespace RuniOS
{
    /// <summary>
    /// 시간을 관리하는 클래스입니다. 모든 연산은 원자적으로 처리됩니다. (Thread-safe)
    /// </summary>
    public static class Time
    {
        /// <summary>
        /// 1970년 1월 1일 00:00:00 협정 세계시 부터의 경과 시간을 나타낸 값입니다. 윤초는 무시됩니다.
        /// </summary>
        public static extern BigTimeSpan time { [SystemCall("RuniOS.Time.time")] get; }

        /// <summary>
        /// 틱과 틱 사이의 시간, 즉 델타타임을 반환합니다. (한치의 오차도 없이 매우 정확한 값입니다.)
        /// </summary>
        public static extern BigTimeSpan deltaTime { [SystemCall("RuniOS.Time.deltaTime")] get; }
    }
}
