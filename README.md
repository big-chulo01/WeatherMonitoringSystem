Weather Monitoring System
A C# implementation of a weather monitoring system that demonstrates several design patterns including Singleton, Observer, Decorator, and Factory patterns.

Features
Singleton Pattern: The WeatherData class is implemented as a singleton to ensure only one instance exists.

Observer Pattern: Displays register as observers and get notified when weather data changes.

Decorator Pattern: The CurrentConditionsDisplay can optionally show date/time information.

Factory Pattern: The WeatherStation class provides factory methods for creating different display types.

Separation of Concerns: Clear separation between interfaces and implementations, and between library and application.

Design Patterns Used
Singleton: WeatherData class

Observer: ISubject and IObserver interfaces with WeatherData as subject

Decorator: CurrentConditionsDisplay with optional decoration

Factory: WeatherStation static class

Project Structure
text
WeatherMonitoringSystem/
├── WeatherMonitoringSystem.sln
├── WeatherMonitoringSystem.Core/ (Class Library)
│   ├── Interfaces/
│   │   ├── IDisplay.cs
│   │   ├── IObserver.cs
│   │   └── ISubject.cs
│   ├── Models/
│   │   ├── WeatherData.cs
│   │   ├── Display/
│   │   │   ├── CurrentConditionsDisplay.cs
│   │   │   ├── ForecastDisplay.cs
│   │   │   └── StatisticsDisplay.cs
│   │   └── WeatherStation.cs
│   └── WeatherMonitoringSystem.Core.csproj
└── WeatherMonitoringSystem.App/ (Console Application)
    ├── Program.cs
    └── WeatherMonitoringSystem.App.csproj
How to Run
Ensure you have .NET SDK installed (version 6.0 or later)

Clone this repository

Navigate to the project directory

Run the following commands:

bash
dotnet build
dotnet run --project WeatherMonitoringSystem.App
Sample Output
text
--- Weather Update 1 ---
Current conditions:
Date: 8/5/2025
Time: 2:30 PM
Temperature: 23°C
Humidity: 45%

Weather Statistics:
Average Temperature: 23°C
Max Temperature: 23°C
Min Temperature: 23°C

Forecast:
Improving weather on the way!

--- Weather Update 2 ---
Current conditions:
Date: 8/5/2025
Time: 2:30 PM
Temperature: 18°C
Humidity: 72%

Weather Statistics:
Average Temperature: 20.5°C
Max Temperature: 23°C
Min Temperature: 18°C

Forecast:
Watch out for cooler, rainy weather
Requirements
.NET 6.0 SDK or later

Visual Studio Code (recommended) or any C# IDE

Implementation Details
The system consists of:

A WeatherData singleton that collects and distributes weather data

Three display types that observe weather changes:

CurrentConditionsDisplay: Shows current weather with optional date/time

StatisticsDisplay: Shows min/max/average temperatures

ForecastDisplay: Predicts weather based on pressure changes

A WeatherStation factory that creates display objects

Design Patterns Explanation
Singleton: Ensures only one WeatherData instance exists to maintain consistent state.

Observer: Allows displays to register for updates without tight coupling to the weather data source.

Decorator: Adds date/time information to the current conditions display without modifying its core functionality.

Factory: Provides a clean interface for creating display objects while hiding implementation details.


