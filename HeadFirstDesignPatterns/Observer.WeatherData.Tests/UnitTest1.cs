using NUnit.Framework;

namespace Observer.WeatherData.Tests;

public class Tests
{
    #region TestCurrentConditionsDisplay

    [Test]
    public void TestCurrentConditionsDisplay()
    {
        WeatherData.SetMeasurements(80, 65, 30.4f);

        Assert.AreEqual("Current conditions: 80F degrees and 65% humidity",
            _currentConditionsDisplay.Display());
    }

    #endregion //TestCurrentConditionsDisplay

    #region TestForecastDisplay

    [Test]
    public void TestForecastDisplay()
    {
        WeatherData.SetMeasurements(81, 63, 31.2f);
        //lastPressure = 29.92f
        Assert.AreEqual("Forecast: Improving weather on the way!",
            _forecastDisplay.Display());

        WeatherData.SetMeasurements(81, 63, 29.92f);
        Assert.AreEqual("Forecast: Watch out for cooler, rainy weather",
            _forecastDisplay.Display());

        WeatherData.SetMeasurements(81, 63, 29.92f);
        Assert.AreEqual("Forecast: More of the same",
            _forecastDisplay.Display());
    }

    #endregion //TestForecastDisplay

    #region TestStatisticsDisplay

    [Test]
    public void TestStatisticsDisplay()
    {
        WeatherData.SetMeasurements(80, 63, 31.2f);
        WeatherData.SetMeasurements(81, 63, 29.92f);
        WeatherData.SetMeasurements(84, 63, 29.92f);
        if (_statisticsDisplay.NumberOfReadings == 3)
            Assert.AreEqual("Avg/Max/Min temperature = 81.667F/84F/80F",
                _statisticsDisplay.Display());
        if (_statisticsDisplay.NumberOfReadings == 8)
            Assert.AreEqual("Avg/Max/Min temperature = 81.000F/84F/80F",
                _statisticsDisplay.Display());
    }

    #endregion //TestStatisticsDisplay

    #region TestHeatIndexDisplay

    [Test]
    public void TestHeatIndexDisplay()
    {
        WeatherData.SetMeasurements(80, 65, 31.2f);
        Assert.AreEqual("Heat index is 82,95535", _heatIndexDisplay.Display());
    }

    #endregion //TestHeatIndexDisplay

    #region Members

    private static readonly WeatherData WeatherData = new();

    private readonly CurrentConditionsDisplay _currentConditionsDisplay =
        new(WeatherData);

    private readonly ForecastDisplay _forecastDisplay = new(WeatherData);
    private readonly StatisticsDisplay _statisticsDisplay = new(WeatherData);
    private readonly HeatIndexDisplay _heatIndexDisplay = new(WeatherData);

    #endregion //Members
}