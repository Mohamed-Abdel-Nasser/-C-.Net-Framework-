namespace EventDelegateExample
{
    public class TemperatureChangedEventArgs : EventArgs
    {
        public string Location { get; }
        public double CurrentTemperature { get; }
        public double OldTemperature { get; }

        public TemperatureChangedEventArgs(string location, double currentTemperature, double oldTemperature)
        {
            Location = location;
            CurrentTemperature = currentTemperature;
            OldTemperature = oldTemperature;
        }
    }
}
