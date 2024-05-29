namespace Facade.HomeTheater;

/// <summary>
///     Summary description for CdPlayer.
/// </summary>
public class CdPlayer(string description, Amplifier amplifier)
{
    private int _currentTrack;
    private string _title;

    public string Description => description;

    public string On()
    {
        return description + " on\n";
    }

    public string Off()
    {
        return description + " off\n";
    }

    public string Eject()
    {
        _title = null;
        return description + " eject\n";
    }

    public string Play(string title)
    {
        _title = title;
        _currentTrack = 0;
        return description + " playing \"" + title + "\"\n";
    }

    public string Play(int track)
    {
        if (_title == null)
        {
            return description + " can't play track " + _currentTrack +
                   ", no cd inserted\n";
        }

        _currentTrack = track;
        return description + " playing track " + _currentTrack + "\n";
    }

    public string Stop()
    {
        _currentTrack = 0;
        return description + " stopped\n";
    }

    public string Pause()
    {
        return description + " paused \"" + _title + "\"\n";
    }
}