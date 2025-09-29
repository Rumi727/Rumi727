namespace RuniOS.Processing
{
    public interface IAnimal : ICreature
    {
        BiologicalSex biologicalSex { get; }

        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        [SystemCall("RuniOS.Processing.IAnimal.SexChange(string)")] extern void SexChange(string command);
    }
}
