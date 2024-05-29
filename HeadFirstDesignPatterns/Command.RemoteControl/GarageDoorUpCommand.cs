namespace Command.RemoteControl;

/// <summary>
///     Summary description for GarageDoorOpenCommand.
/// </summary>
public class GarageDoorUpCommand(GarageDoor garageDoor) : ICommand
{
    #region Command Members

    public object Execute()
    {
        return garageDoor.Up();
    }

    #endregion
}