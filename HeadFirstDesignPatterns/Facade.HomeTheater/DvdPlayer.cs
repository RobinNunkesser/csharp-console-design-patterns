namespace Facade.HomeTheater;

/// <summary>
///     Summary description for DvdPlayer.
/// </summary>
public class DvdPlayer(string description, Amplifier amplifier)
{
    private int _currentTrack;
    private string _movie;

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
        _movie = null;
        return description + " eject\n";
    }

    public string Play(string movie)
    {
        _movie = movie;
        _currentTrack = 0;
        return description + " playing \"" + movie + "\"\n";
    }

    public string Play(int track)
    {
        if (_movie == null)
        {
            return description + " can't play track " + track +
                   " no dvd inserted\n";
        }

        _currentTrack = track;
        return description + " playing track " + _currentTrack + " of \"" +
               _movie + "\"\n";
    }

    public string Stop()
    {
        _currentTrack = 0;
        return description + " stopped \"" + _movie + "\"\n";
    }

    public string Pause()
    {
        return description + " paused \"" + _movie + "\"\n";
    }

    public string SetTwoChannelAudio()
    {
        return description + " set two channel audio\n";
    }

    public string SetSurroundAudio()
    {
        return description + " set surround audio\n";
    }
}