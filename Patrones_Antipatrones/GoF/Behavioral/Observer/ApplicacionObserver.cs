namespace GoF.Behavioral.Observer
{
    public class ApplicacionObserver
    {
        public void Test()
        {
            WeatherStation weatherStation = new WeatherStation();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

            weatherStation.RegisterObserver(currentDisplay);
            weatherStation.RegisterObserver(statisticsDisplay);

            weatherStation.SetTemperature(25.0f);
            weatherStation.SetTemperature(27.0f);
            weatherStation.SetTemperature(23.0f);
        }
    }
}
