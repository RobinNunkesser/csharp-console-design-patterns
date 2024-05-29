namespace Facade.HomeTheater;

/// <summary>
///     Summary description for TheaterLights.
/// </summary>
public class TheaterLights(string description)
{
    public string Description => description;

    public string On()
    {
        return description + " on\n";
    }

    public string Off()
    {
        return description + " off\n";
    }

    public string Dim(int level)
    {
        return description + " dimming to " + level + "%\n";
    }
}