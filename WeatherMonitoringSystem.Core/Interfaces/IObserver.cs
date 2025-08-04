using System;

namespace WeatherMonitoringSystem.Core.Interfaces
{
    /// <summary>
    /// Interface for observers in the Observer pattern.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates the observer with new weather data.
        /// </summary>
        /// <param name="temperature">Current temperature in Celsius</param>
        /// <param name="humidity">Current humidity percentage</param>
        /// <param name="pressure">Current atmospheric pressure in hPa</param>
        void Update(float temperature, float humidity, float pressure);
    }
}