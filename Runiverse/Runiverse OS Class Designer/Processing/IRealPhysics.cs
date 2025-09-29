namespace RuniOS.Processing
{
    public interface IRealPhysics : IFourthDimension, IPhysics
    {
        BigVector3 velocity { get; set; }
        BigComplex mass { get; set; }

        BigComplex temperature { get; set; }
    }
}
