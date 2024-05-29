namespace Command.RemoteControl;

/// <summary>
///     Summary description for Light.
/// </summary>
public class Light(string location)
{
    public string On()
    {
        return location + " light is on";
    }

    public string Off()
    {
        return location + " light is off";
    }
}