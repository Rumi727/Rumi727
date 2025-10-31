namespace RuniOS.Processing.Interfaces.Programs
{
    /// <summary>
    /// 프로세스가 디지털 프로그램일 때 상속되는 인터페이스입니다.
    /// </summary>
    public unsafe interface IDigitalProgram : IProgram
    {
        /// <summary>
        /// 프로그램의 모든 정적 리소스의 (코드, 데이터, 리소스 파일 등, 일반적으로 실행 파일이나 라이브러리에 포함됨) 시작 위치를 나타내는 포인터입니다.
        /// 운영체제에 의해 로드된 프로그램 자체의 원본 데이터를 참조합니다.
        /// </summary>
        /// <exception cref="OverflowException">이 포인터가 가리키는 데이터 영역의 허용 범위를 초과하는 접근을 시도했을 때 발생합니다.</exception>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        byte* datas { get; }

        /// <summary>
        /// 프로그램 실행을 위해 운영체제로부터 할당받은 메모리 공간의 (스택, 힙 등) 시작 위치를 나타내는 포인터입니다.
        /// 프로그램이 동적으로 데이터를 저장하고 작업을 수행하는 메모리상의 주소를 참조합니다.
        /// </summary>
        /// <exception cref="OverflowException">이 포인터가 가리키는 할당 메모리 영역의 주소 범위를 초과하는 접근을 시도했을 때 발생합니다.</exception>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        byte* memory { get; }
    }
}
