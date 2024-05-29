namespace Command.RemoteControl;

/// <summary>
///     Summary description for SimpleRemoteControl
/// </summary>
public class SimpleRemoteControl
{
    private ICommand _slot;

    public object SetCommand(ICommand command)
    {
        _slot = command;
        return _slot;
    }

    public object ButtonWasPressed()
    {
        return _slot.Execute();
    }
}