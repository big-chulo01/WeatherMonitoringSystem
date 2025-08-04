using WeatherMonitoringSystem.Core.Models;
using WeatherMonitoringSystem.Core.Interfaces;
using WeatherMonitoringSystem.Core.Models.Display;

// Create displays using the factory
IDisplay currentDisplay = WeatherStation.CreateCurrentConditionsDisplay(showDateTime: true);
IDisplay statisticsDisplay = WeatherStation.CreateStatisticsDisplay();
IDisplay forecastDisplay = WeatherStation.CreateForecastDisplay();

// Get the singleton instance of WeatherData
WeatherData weatherData = WeatherData.Instance;

// Simulate weather changes
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    float temp = random.Next(10, 30); // Random temperature between 10°C and 30°C
    float humidity = random.Next(30, 90); // Random humidity between 30% and 90%
    float pressure = random.Next(990, 1020); // Random pressure between 990 and 1020 hPa
    
    Console.WriteLine($"\n--- Weather Update {i+1} ---");
    weatherData.SetMeasurements(temp, humidity, pressure);
    
    // Wait between updates
    Thread.Sleep(2000);
}