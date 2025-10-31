using RuniOS.Processing.Interfaces.Creatures;
using RuniOS.Processing.Interfaces.Dimensions;

namespace RuniOS.Processing
{
    public sealed class Kimu : Process, IRuniverse, IAnalogCreature, IHuman
    {
        public string applicationName => "Runiverse OS";
        public Version applicationVersion => throw new NotImplementedException();

        public BigTimeSpan time => throw new NotImplementedException();

        public BigVector3 position
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public BigVector3 velocity
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public BigComplex mass
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public BigComplex temperature
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string name => nameof(Kimu);
        public BigDateTime birthday => throw new NotImplementedException();
        public BigComplex age => throw new NotImplementedException();

        public string nationality => throw new NotImplementedException();
        public BiologicalSex biologicalSex => BiologicalSex.female;

        public override void Kill() => AnalogConverter.ToAnalog(this);
    }
}
