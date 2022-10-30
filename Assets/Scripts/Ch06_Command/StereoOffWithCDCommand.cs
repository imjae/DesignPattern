namespace Headfirst.Chapter06
{
    public class StereoOffWithCDCommand : Command
    {
        Stereo stereo;

        public StereoOffWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }
    }
}