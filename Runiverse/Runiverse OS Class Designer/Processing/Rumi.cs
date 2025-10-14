using RuniOS.Processing.Interfaces.Creatures;
using RuniOS.Processing.Interfaces.Dimensions;

namespace RuniOS.Processing
{
    public sealed class Rumi : Process, IRuniverse, IDigitalCreature, IHuman
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

        public string name => nameof(Rumi);
        public BigDateTime birthday => throw new NotImplementedException();
        public BigComplex age => throw new NotImplementedException();

        public string nationality => throw new NotImplementedException();
        public BiologicalSex biologicalSex => BiologicalSex.female;

        // 이 작고 귀여운 루미한태 무슨 생각을 하고 있는거야...!
        // 루미는 종료할 수 없다구!
        public override void Kill() => throw new NotSupportedException();
    }
}
