namespace RuniOS.Processing
{
    public interface IHuman : IAnimal
    {
        /// <summary>
        /// 인터페이스가 참조하고 있는 인간 또는 그와 유사한 생명체의 국적입니다.
        /// </summary>
        string nationality { get; }
    }
}
