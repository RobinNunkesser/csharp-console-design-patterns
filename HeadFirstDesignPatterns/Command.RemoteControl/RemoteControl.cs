using System.Text;

namespace Command.RemoteControl;

/// <summary>
///     Summary description for RemoteControl.
/// </summary>
//
// This is the invoker
//
public class Remote
{
    private readonly ICommand[] _offCommands;
    private readonly ICommand[] _onCommands;

    public Remote()
    {
        _onCommands = new ICommand[7];
        _offCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();
        for (var i = 0; i < 7; i++)
        {
            _onCommands[i] = noCommand;
            _offCommands[i] = noCommand;
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public object OnButtonWasPushed(int slot)
    {
        return _onCommands[slot].Execute();
    }

    public object OffButtonWasPushed(int slot)
    {
        return _offCommands[slot].Execute();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("\n------ Remote Control -------\n");
        for (var i = 0; i < _onCommands.Length; i++)
            sb.Append("[slot " + i + "] " + _onCommands[i].GetType().Name +
                      "    " + _offCommands[i].GetType().Name + "\n");

        return sb.ToString();
    }
}