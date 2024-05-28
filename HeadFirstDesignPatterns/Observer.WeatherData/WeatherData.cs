using System.Collections;

namespace Observer.WeatherData;

/// <summary>
///     Summary description for WeatherData.
/// </summary>
public class WeatherData : ISubject
{
    private readonly ArrayList _observers = new();
    private float _humidity;
    private float _pressure;
    private float _temperature;

    private void MeasurementsChanged()
    {
        NotifyObserver();
    }

    public void SetMeasurements(float temperature, float humidity,
        float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }

    #region ISubject Members

    public void RegisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        var i = _observers.IndexOf(o);
        if (i >= 0) _observers.Remove(o);
    }

    public void NotifyObserver()
    {
        foreach (IObserver observer in _observers)
            observer.Update(_temperature, _humidity, _pressure);
    }

    #endregion
}