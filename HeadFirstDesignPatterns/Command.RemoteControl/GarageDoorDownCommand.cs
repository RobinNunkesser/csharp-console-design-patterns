namespace Command.RemoteControl;

/// <summary>
///     Summary description for GarageDoorOpenCommand.
/// </summary>
public class GarageDoorDownCommand(GarageDoor garageDoor)
    : ICommand
{
    #region Command Members

    public object Execute()
    {
        return garageDoor.Down();
    }

    #endregion
}