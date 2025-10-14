using RuniOS.Processing.Interfaces.Dimensions.Reality;
using RuniOS.Processing.Interfaces.Programs;

namespace RuniOS.Processing
{
    public sealed class OsuLazer : Process, IProgram, IWindows
    {
        public string applicationName => "osu!lazer";
        public Version applicationVersion => new Version(2025, 912, 0);

        public Process? linkedDevice => throw new NotImplementedException();

        public IReadOnlyList<Process> linkedServers => throw new NotImplementedException();
        public Process? currentServer => throw new NotImplementedException();


        public override void Kill() => throw new NotImplementedException();
    }
}
