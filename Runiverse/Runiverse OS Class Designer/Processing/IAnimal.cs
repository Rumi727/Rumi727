namespace RuniOS.Processing
{
    public interface IAnimal : ICreature
    {
        BiologicalSex biologicalSex { get; }

        [SystemCall("RuniOS.Processing.IAnimal.SexChange(string)")] extern void SexChange(string command);
    }
}
