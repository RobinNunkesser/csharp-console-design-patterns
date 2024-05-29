namespace Command.RemoteControl;

/// <summary>
///     Summary description for LightOnCommand.
/// </summary>
public class LightOnCommand(Light light) : ICommand
{
    #region Command Members

    public object Execute()
    {
        return light.On();
    }

    #endregion
}