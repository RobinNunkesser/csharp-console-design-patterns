namespace Observer.WeatherData;

/// <summary>
///     Summary description for CurrentConditionsDisplay.
/// </summary>
public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _humidity;
    private float _pressure;
    private float _temperature;
    private ISubject _weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    #region IDisplayElement Members

    public object Display()
    {
        return "Current conditions: " + _temperature + "F degrees and " +
               _humidity + "% humidity";
    }

    #endregion

    #region IObserver Members

    public void Update(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
    }

    #endregion
}