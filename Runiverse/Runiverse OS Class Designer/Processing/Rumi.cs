namespace RuniOS.Processing
{
    public class Rumi : Process, IRuniverse, IDigitalCreature, IHuman
    {
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

        public string name => throw new NotImplementedException();
        public BigDateTime birthday => throw new NotImplementedException();

        public string nationality => throw new NotImplementedException();
        public BiologicalSex biologicalSex => throw new NotImplementedException();
    }
}
