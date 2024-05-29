namespace Command.RemoteControl;

/// <summary>
///     Summary description for LightOnCommand.
/// </summary>
public class LightOffCommand(Light light) : ICommand
{
    #region Command Members

    public object Execute()
    {
        return light.Off();
    }

    #endregion
}