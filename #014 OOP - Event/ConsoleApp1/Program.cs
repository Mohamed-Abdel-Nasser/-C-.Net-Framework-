using System;

namespace EventDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperatureSensor = new TemperatureSensor();

            // Subscribe to the TemperatureChanged event
            temperatureSensor.TemperatureChanged += DisplayTemperatureChange;

            // Simulate temperature changes
            temperatureSensor.SetTemperature(25); // Normal temperature
            temperatureSensor.SetTemperature(30); // Temperature increase
            temperatureSensor.SetTemperature(20); // Temperature decrease

            Console.ReadKey();
        }

        private static void DisplayTemperatureChange(object sender, TemperatureChangedEventArgs e)
        {
            string message;
            if (e.CurrentTemperature > e.OldTemperature)
                message = "Temperature increased";
            else if (e.CurrentTemperature < e.OldTemperature)
                message = "Temperature decreased";
            else
                message = "Temperature unchanged";

            Console.WriteLine($"{e.Location}: {e.CurrentTemperature}°C - {message}");
        }
    }

    public delegate void TemperatureChangedEventHandler(object sender, TemperatureChangedEventArgs e);
}
