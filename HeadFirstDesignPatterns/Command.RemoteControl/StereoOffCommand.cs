namespace Command.RemoteControl;

/// <summary>
///     Summary description for StereoOffCommand.
/// </summary>
public class StereoOffCommand(Stereo stereo) : ICommand
{
    #region Command Members

    public object Execute()
    {
        return stereo.Off();
    }

    #endregion
}