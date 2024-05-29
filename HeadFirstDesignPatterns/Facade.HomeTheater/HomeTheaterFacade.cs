using System.Text;

namespace Facade.HomeTheater;

/// <summary>
///     Summary description for HomeTheaterFacade.
/// </summary>
public class HomeTheaterFacade(
    Amplifier amp,
    Tuner tuner,
    DvdPlayer dvd,
    CdPlayer cd,
    Projector projector,
    Screen screen,
    TheaterLights lights,
    PopcornPopper popper)
{
    public object WatchMovie(string movie)
    {
        var watchMovieString = new StringBuilder();

        watchMovieString.Append("Get ready to watch a movie...\n");
        watchMovieString.Append(popper.On());
        watchMovieString.Append(popper.Pop());
        watchMovieString.Append(lights.Dim(10));
        watchMovieString.Append(screen.Down());
        watchMovieString.Append(projector.On());
        watchMovieString.Append(projector.WideScreenMode());
        watchMovieString.Append(amp.On());
        watchMovieString.Append(amp.SetDvd(dvd));
        watchMovieString.Append(amp.SetSurroundSound());
        watchMovieString.Append(amp.SetVolume(5));
        watchMovieString.Append(dvd.On());
        watchMovieString.Append(dvd.Play(movie));

        return watchMovieString.ToString();
    }


    public object EndMovie()
    {
        var endMovieString = new StringBuilder();

        endMovieString.Append("Shutting movie theater down...\n");
        endMovieString.Append(popper.Off());
        endMovieString.Append(lights.On());
        endMovieString.Append(screen.Up());
        endMovieString.Append(projector.Off());
        endMovieString.Append(amp.Off());
        endMovieString.Append(dvd.Stop());
        endMovieString.Append(dvd.Eject());
        endMovieString.Append(dvd.Off());

        return endMovieString.ToString();
    }

    public object ListenToCd(string cdTitle)
    {
        var listenToCdString = new StringBuilder();

        listenToCdString.Append("Get ready for an audio experence...\n");
        listenToCdString.Append(lights.On());
        listenToCdString.Append(amp.On());
        listenToCdString.Append(amp.SetVolume(5));
        listenToCdString.Append(amp.SetCd(cd));
        listenToCdString.Append(amp.SetStereoSound());
        listenToCdString.Append(cd.On());
        listenToCdString.Append(cd.Play(cdTitle));

        return listenToCdString.ToString();
    }

    public object EndCd()
    {
        var endCdString = new StringBuilder();

        endCdString.Append("Shutting down CD...\n");
        endCdString.Append(amp.Off());
        endCdString.Append(amp.SetCd(cd));
        endCdString.Append(cd.Eject());
        endCdString.Append(cd.Off());

        return endCdString.ToString();
    }

    public object ListenToRadio(double frequency)
    {
        var listenToRadioString = new StringBuilder();

        listenToRadioString.Append("Tuning in the airwaves...\n");
        listenToRadioString.Append(tuner.On());
        listenToRadioString.Append(tuner.SetFrequency(frequency));
        listenToRadioString.Append(amp.On());
        listenToRadioString.Append(amp.SetVolume(5));
        listenToRadioString.Append(amp.SetTuner(tuner));

        return listenToRadioString.ToString();
    }

    public object EndRadio()
    {
        var endRadioString = new StringBuilder();

        endRadioString.Append("Shutting down the tuner...\n");
        endRadioString.Append(tuner.Off());
        endRadioString.Append(amp.Off());

        return endRadioString.ToString();
    }
}