using System.Numerics;

namespace RuniOS
{
    /// <summary>
    /// 프로세스에 대한 <b>모든 정보를</b> 가지고 관리합니다.<br/>
    /// <see cref="System.Reflection.Emit.TypeBuilder"/> 클래스 등을 사용하여 프로세스마다 <see cref="Process"/> 클래스와 여러 인터페이스를 상속 받은 적절한 타입을 동적으로 생성합니다.
    /// <br/><br/>
    /// 예를 들어서 현실의 우주에서 온 물질이라면 <see cref="Processing.Interfaces.Dimensions.Reality.IUniverse"/> 인터페이스를 상속할 것 입니다.<br/>
    /// </summary>
    public abstract unsafe class Process
    {
        /// <summary>
        /// 운영체제에 로드된 모든 프로세스 목록을 가져옵니다.
        /// </summary>
        public static IReadOnlyList<Process> processes { get; } = [];

        /// <summary>
        /// 메모리상에서 물질에 대한 모든 데이터를 가지고 있는 위치를 가리키는 포인터이다.<br/>
        /// 포인터가 가르키는 메모리 위치는 Ring 0 권한을 가진 스레드만 접근할 수 있게 보호된 위치입니다.
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        public void* substance { get; }

        /// <summary>
        /// 프로세스 고유의 id 값 입니다.
        /// </summary>
        public BigInteger id { get; }

        /// <summary>
        /// 프로세스의 특권 레벨 입니다.
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        /// <exception cref="NotSupportedException">커널의 특권 레벨을 변경하려할 때 발생하는 예외입니다.</exception>
        public int privilegeLevel
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// 프로세스를 운영체제에서 강제 종료합니다.
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        public abstract void Kill();
    }
}
