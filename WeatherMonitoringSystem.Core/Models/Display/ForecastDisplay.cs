using WeatherMonitoringSystem.Core.Interfaces;

namespace WeatherMonitoringSystem.Core.Models.Display
{
    /// <summary>
    /// Displays weather forecast based on current conditions.
    /// </summary>
    public class ForecastDisplay : IObserver, IDisplay
    {
        private float _lastPressure;
        private float _currentPressure;

        /// <summary>
        /// Initializes a new instance of the ForecastDisplay class.
        /// </summary>
        public ForecastDisplay()
        {
            WeatherData.Instance.RegisterObserver(this);
            _currentPressure = 1012.0f; // Default pressure
        }

        /// <summary>
        /// Updates the forecast with new weather data.
        /// </summary>
        public void Update(float temperature, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
            Display();
        }

        /// <summary>
        /// Displays the weather forecast.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Forecast:");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
            Console.WriteLine();
        }
    }
}