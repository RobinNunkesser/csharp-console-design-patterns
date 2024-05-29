namespace Facade.HomeTheater;

/// <summary>
///     Summary description for Tuner.
/// </summary>
public class Tuner(string description, Amplifier amplifier)
{
    private double _frequency;
    public string Description => description;

    public string On()
    {
        return description + " on\n";
    }

    public string Off()
    {
        return description + " off\n";
    }

    public string SetFrequency(double frequency)
    {
        _frequency = frequency;
        return description + " setting frequency to " + frequency + "\n";
    }

    public string SetAm()
    {
        return description + " setting AM mode\n";
    }

    public string SetFm()
    {
        return description + " setting FM mode\n";
    }
}