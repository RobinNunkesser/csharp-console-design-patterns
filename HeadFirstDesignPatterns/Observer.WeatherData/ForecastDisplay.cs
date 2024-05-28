using System;
using System.Text;

namespace Observer.WeatherData;

/// <summary>
///     Summary description for ForcastDisplay.
/// </summary>
public class ForecastDisplay : IObserver, IDisplayElement
{
    private float _currentPressure = 29.92f;
    private float _lastPressure;
    private ISubject _weatherData;

    public ForecastDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    #region IDisplayElement Members

    public object Display()
    {
        var sb = new StringBuilder();

        sb.Append("Forecast: ");

        if (_currentPressure > _lastPressure)
            sb.Append("Improving weather on the way!");
        else if (Math.Abs(_currentPressure - _lastPressure) < 0.02)
            sb.Append("More of the same");
        else if (_currentPressure < _lastPressure)
            sb.Append("Watch out for cooler, rainy weather");

        return sb.ToString();
    }

    #endregion

    #region IObserver Members

    public void Update(float temperature, float humidity, float pressure)
    {
        _lastPressure = _currentPressure;
        _currentPressure = pressure;
    }

    #endregion
}