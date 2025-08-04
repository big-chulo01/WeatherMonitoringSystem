using WeatherMonitoringSystem.Core.Interfaces;
using System.Collections.Generic;

namespace WeatherMonitoringSystem.Core.Models
{
    /// <summary>
    /// Singleton class that holds weather data and notifies observers when data changes.
    /// </summary>
    public sealed class WeatherData : ISubject
    {
        private static WeatherData? _instance;
        private static readonly object _lock = new object();
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        /// <summary>
        /// Private constructor for singleton pattern.
        /// </summary>
        private WeatherData()
        {
            _observers = new List<IObserver>();
        }

        /// <summary>
        /// Gets the singleton instance of WeatherData.
        /// </summary>
        public static WeatherData Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new WeatherData();
                    }
                    return _instance;
                }
            }
        }

        /// <summary>
        /// Registers an observer to receive updates.
        /// </summary>
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Removes an observer from receiving updates.
        /// </summary>
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all observers when weather data changes.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        /// <summary>
        /// Sets new weather measurements and notifies observers.
        /// </summary>
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}