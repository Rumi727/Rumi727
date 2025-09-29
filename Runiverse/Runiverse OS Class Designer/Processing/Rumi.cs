namespace RuniOS.Processing
{
    public class Rumi : Process, IRuniverse, IDigitalCreature, IHuman
    {
        public BigTimeSpan time => throw new NotImplementedException();

        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        public BigVector3 position 
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        public BigVector3 velocity
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
        public BigComplex mass
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <exception cref="UnauthorizedAccessException">적절한 권한이 없을때 발생하는 예외입니다.</exception>
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
