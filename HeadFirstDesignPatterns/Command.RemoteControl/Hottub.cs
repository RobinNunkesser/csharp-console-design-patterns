namespace Command.RemoteControl;

/// <summary>
///     Summary description for Hottub.
/// </summary>
public abstract class Hottub
{
    private bool _on;
    private int _temperature;

    public bool On()
    {
        _on = true;
        return _on;
    }

    public bool Off()
    {
        _on = false;
        return _on;
    }

    public string BubblesOn()
    {
        return _on ? "Hottub is bubbling!" : null;
    }

    public string BubblesOff()
    {
        return _on ? "Hottub is not bubbling" : null;
    }

    public string JetsOn()
    {
        return _on ? "Hottub jets are on" : null;
    }

    public string JetsOff()
    {
        return _on ? "Hottub jets are off" : null;
    }

    public int SetTemperature(int temperature)
    {
        _temperature = temperature;
        return temperature;
    }

    public string Heat()
    {
        _temperature = 105;
        return "Hottub is heating to a steaming 105 degrees";
    }

    public string Cool()
    {
        _temperature = 98;
        return "Hottub is cooling to 98 degrees";
    }
}