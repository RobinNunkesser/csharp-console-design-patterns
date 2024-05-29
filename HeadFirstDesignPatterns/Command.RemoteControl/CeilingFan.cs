namespace Command.RemoteControl;

/// <summary>
///     Summary description for CeilingFan.
/// </summary>
public class CeilingFan(string location)
{
    private const int HIGH = 2;
    private const int MEDIUM = 1;
    private const int LOW = 0;
    private int _level;

    public string High()
    {
        // turns the ceiling fan on to high
        _level = HIGH;
        return location + " ceiling fan is on high";
    }

    public string Medium()
    {
        // turns the ceiling fan on to medium
        _level = MEDIUM;
        return location + " ceiling fan is on medium";
    }

    public string Low()
    {
        // turns the ceiling fan on to low
        _level = LOW;
        return location + " ceiling fan is on low";
    }

    public string Off()
    {
        // turns the ceiling fan off
        _level = 0;
        return location + " ceiling fan is off";
    }

    public int GetSpeed()
    {
        return _level;
    }
}