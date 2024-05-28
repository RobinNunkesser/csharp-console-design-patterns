using NUnit.Framework;

namespace HeadFirstDesignPatterns.Observer.WeatherData.Tests;

public class Tests
{
    #region TestCurrentConditionsDisplay

    [Test]
    public void TestCurrentConditionsDisplay()
    {
        weatherData.SetMeasurements(80, 65, 30.4f);

        Assert.AreEqual("Current conditions: 80F degrees and 65% humidity",
            currentConditionsDisplay.Display());
    }

    #endregion //TestCurrentConditionsDisplay

    #region TestForecastDisplay

    [Test]
    public void TestForecastDisplay()
    {
        weatherData.SetMeasurements(81, 63, 31.2f);
        //lastPressure = 29.92f
        Assert.AreEqual("Forecast: Improving weather on the way!",
            forcastDisplay.Display());

        weatherData.SetMeasurements(81, 63, 29.92f);
        Assert.AreEqual("Forecast: Watch out for cooler, rainy weather",
            forcastDisplay.Display());

        weatherData.SetMeasurements(81, 63, 29.92f);
        Assert.AreEqual("Forecast: More of the same",
            forcastDisplay.Display());
    }

    #endregion //TestForecastDisplay

    #region TestStatisticsDisplay

    [Test]
    public void TestStatisticsDisplay()
    {
        weatherData.SetMeasurements(80, 63, 31.2f);
        weatherData.SetMeasurements(81, 63, 29.92f);
        weatherData.SetMeasurements(84, 63, 29.92f);
        if (statisticsDisplay.NumberOfReadings == 3)
            Assert.AreEqual("Avg/Max/Min temperature = 81.667F/84F/80F",
                statisticsDisplay.Display());
        if (statisticsDisplay.NumberOfReadings == 8)
            Assert.AreEqual("Avg/Max/Min temperature = 81.000F/84F/80F",
                statisticsDisplay.Display());
    }

    #endregion //TestStatisticsDisplay

    #region TestHeatIndexDisplay

    [Test]
    public void TestHeatIndexDisplay()
    {
        weatherData.SetMeasurements(80, 65, 31.2f);
        Assert.AreEqual("Heat index is 82,95535", heatIndexDisplay.Display());
    }

    #endregion //TestHeatIndexDisplay

    #region Members

    private static readonly WeatherData weatherData = new();

    private readonly CurrentConditionsDisplay currentConditionsDisplay =
        new(weatherData);

    private readonly ForcastDisplay forcastDisplay = new(weatherData);
    private readonly StatisticsDisplay statisticsDisplay = new(weatherData);
    private readonly HeatIndexDisplay heatIndexDisplay = new(weatherData);

    #endregion //Members
}