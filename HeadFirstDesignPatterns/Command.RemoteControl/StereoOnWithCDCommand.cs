namespace Command.RemoteControl;

/// <summary>
///     Summary description for StereoOnWithCDCommand.
/// </summary>
public class StereoOnWithCDCommand(Stereo stereo) : ICommand
{
    #region Command Members

    public object Execute()
    {
        return stereo.On() + "\n" + stereo.SetCD() + "\n" +
               stereo.SetVolume(11);
    }

    #endregion
}