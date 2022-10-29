namespace Headfirst.Chapter06
{
    public class Light
    {
        public void On()
        {

        }
    }

    public class LightOnCommand : Command
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }
}