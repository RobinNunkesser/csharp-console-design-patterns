namespace Command.RemoteControl;

/// <summary>
///     Summary description for CeilingFanOnCommand.
/// </summary>
public class CeilingFanOffCommand(CeilingFan ceilingFan) : ICommand
{
    #region Command Members

    public object Execute()
    {
        return ceilingFan.Off();
    }

    #endregion
}