using System.Text;

namespace Headfirst.Chapter06
{
    public class NoCommand : Command
    {
        public void Execute()
        {

        }
    }

    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\n------ 리모컨 ------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append($"[slot{i}] {onCommands[i].ToString()}     {offCommands[i].ToString()}\n");
            }

            return sb.ToString();
        }
    }
}