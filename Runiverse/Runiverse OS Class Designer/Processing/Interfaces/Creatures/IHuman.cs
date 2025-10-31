namespace RuniOS.Processing.Interfaces.Creatures
{
    /// <summary>
    /// 프로세스가 인간 또는 그와 유사한 생명체일 때 상속되는 인터페이스입니다.
    /// </summary>
    public interface IHuman : IAnimal
    {
        /// <summary>
        /// 인터페이스가 참조하고 있는 인간 또는 그와 유사한 생명체의 국적입니다.
        /// </summary>
        string nationality { get; }
    }
}
