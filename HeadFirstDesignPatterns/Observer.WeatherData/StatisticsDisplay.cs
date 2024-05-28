using System.Globalization;

namespace Observer.WeatherData;

/// <summary>
///     Summary description for StatisticsDisplay.
/// </summary>
public class StatisticsDisplay : IObserver, IDisplayElement
{
    #region Constructor

    public StatisticsDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    #endregion //Constructor

    #region NumberOfReadings Property

    public int NumberOfReadings { get; private set; }

    #endregion //NumberOfReadings Property

    #region IDisplayElement Members

    public object Display()
    {
        return "Avg/Max/Min temperature = " +
               RoundFloatToString(_temperatureSum / NumberOfReadings) + "F/" +
               _maxTemp + "F/" + _minTemp + "F";
    }

    #endregion

    #region IObserver Members

    public void Update(float temperature, float humidity, float pressure)
    {
        _temperatureSum += temperature;
        NumberOfReadings++;

        if (temperature > _maxTemp) _maxTemp = temperature;

        if (temperature < _minTemp) _minTemp = temperature;
    }

    #endregion

    #region RoundFloatToString

    private static string RoundFloatToString(float floatToRound)
    {
        var cultureInfo =
            new CultureInfo("en-US")
            {
                NumberFormat =
                {
                    CurrencyDecimalDigits = 2,
                    CurrencyDecimalSeparator = "."
                }
            };
        return floatToRound.ToString("F", cultureInfo);
    }

    #endregion //RoundFloatToString

    #region Members

    private float _maxTemp;

    private float _minTemp = 200; //set intial high so that minimum 

    //is set first invokation
    private float _temperatureSum;
    private ISubject _weatherData;

    #endregion //Members
}