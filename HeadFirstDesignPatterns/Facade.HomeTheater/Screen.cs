namespace Facade.HomeTheater;

/// <summary>
///     Summary description for Screen.
/// </summary>
public class Screen(string description)
{
    public string Description => description;

    public string Up()
    {
        return description + " going up\n";
    }

    public string Down()
    {
        return description + " going down\n";
    }
}