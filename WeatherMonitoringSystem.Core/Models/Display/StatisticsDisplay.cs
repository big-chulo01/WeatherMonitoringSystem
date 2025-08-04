using WeatherMonitoringSystem.Core.Interfaces;
using System.Collections.Generic;

namespace WeatherMonitoringSystem.Core.Models.Display
{
    /// <summary>
    /// Displays weather statistics (min, max, average temperatures).
    /// </summary>
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private List<float> _temperatures = new List<float>();

        /// <summary>
        /// Initializes a new instance of the StatisticsDisplay class.
        /// </summary>
        public StatisticsDisplay()
        {
            WeatherData.Instance.RegisterObserver(this);
        }

        /// <summary>
        /// Updates the statistics with new weather data.
        /// </summary>
        public void Update(float temperature, float humidity, float pressure)
        {
            _temperatures.Add(temperature);
            Display();
        }

        /// <summary>
        /// Displays the weather statistics.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Weather Statistics:");
            Console.WriteLine($"Average Temperature: {_temperatures.Average()}°C");
            Console.WriteLine($"Max Temperature: {_temperatures.Max()}°C");
            Console.WriteLine($"Min Temperature: {_temperatures.Min()}°C");
            Console.WriteLine();
        }
    }
}