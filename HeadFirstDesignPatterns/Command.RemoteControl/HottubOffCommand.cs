namespace Command.RemoteControl;

/// <summary>
///     Summary description for HottubOnCommand.
/// </summary>
public class HottubOffCommand(Hottub hottub) : ICommand
{
    #region Command Members

    public object Execute()
    {
        return hottub.Off();
    }

    #endregion
}