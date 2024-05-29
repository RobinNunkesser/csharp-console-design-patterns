namespace Command.RemoteControl;

/// <summary>
///     Summary description for CeilingFanOnCommand.
/// </summary>
public class CeilingFanOnCommand(CeilingFan ceilingFan) : ICommand
{
    #region Command Members

    public object Execute()
    {
        return ceilingFan.High();
    }

    #endregion
}