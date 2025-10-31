using RuniOS.Processing.Interfaces.Dimensions.Reality;
using RuniOS.Processing.Interfaces.Programs;

namespace RuniOS.Processing
{
    public sealed class TetrIO : Process, IProgram, IInternet
    {
        public string applicationName => "TETR.IO";
        public Version applicationVersion => new Version(1, 7, 4);

        public Process? linkedDevice { get; }

        public IReadOnlyList<Process> linkedServers => throw new NotImplementedException();
        public Process? currentServer => throw new NotImplementedException();

        public override void Kill() => throw new NotImplementedException();
    }
}
