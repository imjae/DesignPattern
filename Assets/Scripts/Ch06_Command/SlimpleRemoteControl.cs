namespace Headfirst.Chapter06
{
    public class SimpleRemoteControl
    {
        private Command slot;

        public SimpleRemoteControl() { }

        public void SetCommand(Command command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}