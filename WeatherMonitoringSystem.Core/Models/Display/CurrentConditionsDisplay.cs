using WeatherMonitoringSystem.Core.Interfaces;

namespace WeatherMonitoringSystem.Core.Models.Display
{
    /// <summary>
    /// Displays current weather conditions with optional decorated information.
    /// </summary>
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private float _humidity;
        private readonly bool _showDateTime;

        /// <summary>
        /// Initializes a new instance of the CurrentConditionsDisplay class.
        /// </summary>
        /// <param name="showDateTime">Whether to show date and time (decorator pattern).</param>
        public CurrentConditionsDisplay(bool showDateTime = false)
        {
            _showDateTime = showDateTime;
            WeatherData.Instance.RegisterObserver(this);
        }

        /// <summary>
        /// Updates the display with new weather data.
        /// </summary>
        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        /// <summary>
        /// Displays the current weather conditions.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Current conditions:");
            if (_showDateTime)
            {
                Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}");
                Console.WriteLine($"Time: {DateTime.Now.ToShortTimeString()}");
            }
            Console.WriteLine($"Temperature: {_temperature}°C");
            Console.WriteLine($"Humidity: {_humidity}%");
            Console.WriteLine();
        }
    }
}