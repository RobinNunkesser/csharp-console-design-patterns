namespace Command.RemoteControl;

/// <summary>
///     Summary description for HottubOnCommand.
/// </summary>
public class HottubOnCommand(Hottub hottub) : ICommand
{
    #region Command Members

    public object Execute()
    {
        return hottub.On() + "\n" + hottub.Heat() + "\n" +
               hottub.BubblesOn();
    }

    #endregion
}