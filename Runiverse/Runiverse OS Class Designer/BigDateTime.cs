namespace RuniOS
{
    public struct BigDateTime(BigTimeSpan offset)
    {
        /// <summary>
        /// 1970년 1월 1일 00:00:00 협정 세계시 부터의 경과 시간을 나타낸 값입니다. 윤초는 무시됩니다.
        /// </summary>
        public BigTimeSpan offset { get; set; } = offset;
    }
}
