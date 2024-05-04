namespace EventDelegateExample
{
    public class TemperatureSensor
    {
        public event TemperatureChangedEventHandler TemperatureChanged;

        private string location;
        private double currentTemperature;

        public string Location => this.location;
        public double CurrentTemperature => this.currentTemperature;

        public TemperatureSensor()
        {
            location = "Living Room";
            currentTemperature = 25; // Initial temperature
        }

        public void SetTemperature(double newTemperature)
        {
            double oldTemperature = currentTemperature;
            currentTemperature = newTemperature;
            OnTemperatureChanged(oldTemperature);
        }

        protected virtual void OnTemperatureChanged(double oldTemperature)
        {
            TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(location, currentTemperature, oldTemperature));
        }
    }
}
