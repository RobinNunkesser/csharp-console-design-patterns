using System.Text;
using NUnit.Framework;

namespace Facade.HomeTheater.Tests;

public class Tests
{
    #region Setup

    public Tests()
    {
        _amp = new Amplifier("Top-O-Line Amplifier");
        _tuner = new Tuner("Top-O-Line Tuner", _amp);
        _dvd = new DvdPlayer("Top-O-Line DVD Player", _amp);
        _cd = new CdPlayer("Top-O-Line CD Player", _amp);
        _projector = new Projector("Top-O-Line Projector", _dvd);
        _lights = new TheaterLights("Theater Ceiling Lights");
        _screen = new Screen("Theater Screen");
        _popper = new PopcornPopper("Popcorn Popper");
        _expectedWatchMovieOutput = new StringBuilder();
        _expectedEndMovieOutput = new StringBuilder();
        _expectedListenToCdOutput = new StringBuilder();
        _expectedEndCdOutput = new StringBuilder();
        _expectedListenToRadioOutput = new StringBuilder();
        _expectedEndRadioOutput = new StringBuilder();
        _homeTheater = new HomeTheaterFacade(_amp, _tuner,
            _dvd, _cd, _projector, _screen, _lights, _popper);
    }

    #endregion //Setup

    #region TearDown Dispose()

    public void Dispose()
    {
        _amp = null;
        _tuner = null;
        _dvd = null;
        _cd = null;
        _projector = null;
        _lights = null;
        _screen = null;
        _popper = null;
        _expectedWatchMovieOutput = null;
        _expectedEndMovieOutput = null;
        _expectedListenToCdOutput = null;
        _expectedEndCdOutput = null;
        _expectedListenToRadioOutput = null;
        _expectedEndRadioOutput = null;
        _homeTheater = null;
    }

    #endregion //TearDown Dispose()

    #region TestHomeTheaterMovie

    [Test]
    public void TestHomeTheaterMovie()
    {
        _expectedWatchMovieOutput.Append("Get ready to watch a movie...\n");
        _expectedWatchMovieOutput.Append("Popcorn Popper on\n");
        _expectedWatchMovieOutput.Append("Popcorn Popper popping popcorn!\n");
        _expectedWatchMovieOutput.Append(
            "Theater Ceiling Lights dimming to 10%\n");
        _expectedWatchMovieOutput.Append("Theater Screen going down\n");
        _expectedWatchMovieOutput.Append("Top-O-Line Projector on\n");
        _expectedWatchMovieOutput.Append(
            "Top-O-Line Projector in widescreen mode (16x9 aspect ratio)\n");
        _expectedWatchMovieOutput.Append("Top-O-Line Amplifier on\n");
        _expectedWatchMovieOutput.Append(
            "Top-O-Line Amplifier setting DVD player to Top-O-Line DVD Player\n");
        _expectedWatchMovieOutput.Append(
            "Top-O-Line Amplifier surround sound on (5 speakers, 1 subwoofer)\n");
        _expectedWatchMovieOutput.Append(
            "Top-O-Line Amplifier setting volume to 5\n");
        _expectedWatchMovieOutput.Append("Top-O-Line DVD Player on\n");
        _expectedWatchMovieOutput.Append(
            "Top-O-Line DVD Player playing \"Toy Story\"\n");

        _expectedEndMovieOutput.Append("Shutting movie theater down...\n");
        _expectedEndMovieOutput.Append("Popcorn Popper off\n");
        _expectedEndMovieOutput.Append("Theater Ceiling Lights on\n");
        _expectedEndMovieOutput.Append("Theater Screen going up\n");
        _expectedEndMovieOutput.Append("Top-O-Line Projector off\n");
        _expectedEndMovieOutput.Append("Top-O-Line Amplifier off\n");
        _expectedEndMovieOutput.Append(
            "Top-O-Line DVD Player stopped \"Toy Story\"\n");
        _expectedEndMovieOutput.Append("Top-O-Line DVD Player eject\n");
        _expectedEndMovieOutput.Append("Top-O-Line DVD Player off\n");

        Assert.AreEqual(_expectedWatchMovieOutput.ToString(),
            _homeTheater.WatchMovie("Toy Story"));
        Assert.AreEqual(_expectedEndMovieOutput.ToString(),
            _homeTheater.EndMovie());
    }

    #endregion //TestHomeTheaterMovie

    #region TestHomeTheaterCD

    [Test]
    public void TestHomeTheaterCD()
    {
        _expectedListenToCdOutput.Append(
            "Get ready for an audio experence...\n");
        _expectedListenToCdOutput.Append("Theater Ceiling Lights on\n");
        _expectedListenToCdOutput.Append("Top-O-Line Amplifier on\n");
        _expectedListenToCdOutput.Append(
            "Top-O-Line Amplifier setting volume to 5\n");
        _expectedListenToCdOutput.Append(
            "Top-O-Line Amplifier setting CD player to Top-O-Line CD Player\n");
        _expectedListenToCdOutput.Append(
            "Top-O-Line Amplifier stereo mode on\n");
        _expectedListenToCdOutput.Append("Top-O-Line CD Player on\n");
        _expectedListenToCdOutput.Append(
            "Top-O-Line CD Player playing \"Dark Side of the Moon\"\n");

        _expectedEndCdOutput.Append("Shutting down CD...\n");
        _expectedEndCdOutput.Append("Top-O-Line Amplifier off\n");
        _expectedEndCdOutput.Append(
            "Top-O-Line Amplifier setting CD player to Top-O-Line CD Player\n");
        _expectedEndCdOutput.Append("Top-O-Line CD Player eject\n");
        _expectedEndCdOutput.Append("Top-O-Line CD Player off\n");

        Assert.AreEqual(_expectedListenToCdOutput.ToString(),
            _homeTheater.ListenToCd("Dark Side of the Moon"));
        Assert.AreEqual(_expectedEndCdOutput.ToString(),
            _homeTheater.EndCd());
    }

    #endregion //TestHomeTheaterCD

    #region TestHomeTheaterRadio

    [Test]
    public void TestHomeTheaterRadio()
    {
        _expectedListenToRadioOutput.Append("Tuning in the airwaves...\n");
        _expectedListenToRadioOutput.Append("Top-O-Line Tuner on\n");
        _expectedListenToRadioOutput.Append(
            "Top-O-Line Tuner setting frequency to 92,5\n");
        _expectedListenToRadioOutput.Append("Top-O-Line Amplifier on\n");
        _expectedListenToRadioOutput.Append(
            "Top-O-Line Amplifier setting volume to 5\n");
        _expectedListenToRadioOutput.Append(
            "Top-O-Line Amplifier setting tuner to Top-O-Line Tuner\n");

        _expectedEndRadioOutput.Append("Shutting down the tuner...\n");
        _expectedEndRadioOutput.Append("Top-O-Line Tuner off\n");
        _expectedEndRadioOutput.Append("Top-O-Line Amplifier off\n");


        Assert.AreEqual(_expectedListenToRadioOutput.ToString(),
            _homeTheater.ListenToRadio(92.5));
        Assert.AreEqual(_expectedEndRadioOutput.ToString(),
            _homeTheater.EndRadio());
    }

    #endregion //TestHomeTheaterRadio

    #region Members

    private Amplifier _amp;
    private Tuner _tuner;
    private DvdPlayer _dvd;
    private CdPlayer _cd;
    private Projector _projector;
    private TheaterLights _lights;
    private Screen _screen;
    private PopcornPopper _popper;
    private HomeTheaterFacade _homeTheater;
    private StringBuilder _expectedWatchMovieOutput;
    private StringBuilder _expectedEndMovieOutput;
    private StringBuilder _expectedListenToCdOutput;
    private StringBuilder _expectedEndCdOutput;
    private StringBuilder _expectedListenToRadioOutput;
    private StringBuilder _expectedEndRadioOutput;

    #endregion //Members
}