using WeatherMonitoringSystem.Core.Interfaces;
using WeatherMonitoringSystem.Core.Models.Display;

namespace WeatherMonitoringSystem.Core.Models
{
    /// <summary>
    /// Factory for creating different types of display elements.
    /// </summary>
    public static class WeatherStation
    {
        /// <summary>
        /// Creates a current conditions display.
        /// </summary>
        /// <param name="showDateTime">Whether to show date and time (decorator pattern).</param>
        /// <returns>An IDisplay object for current conditions.</returns>
        public static IDisplay CreateCurrentConditionsDisplay(bool showDateTime = false)
        {
            return new CurrentConditionsDisplay(showDateTime);
        }

        /// <summary>
        /// Creates a statistics display.
        /// </summary>
        /// <returns>An IDisplay object for statistics.</returns>
        public static IDisplay CreateStatisticsDisplay()
        {
            return new StatisticsDisplay();
        }

        /// <summary>
        /// Creates a forecast display.
        /// </summary>
        /// <returns>An IDisplay object for forecasts.</returns>
        public static IDisplay CreateForecastDisplay()
        {
            return new ForecastDisplay();
        }
    }
}