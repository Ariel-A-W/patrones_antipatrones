
namespace GoF.Behavioral.Observer
{
    public class WeatherStation : ISubject
    {
        private List<IObserver>? _observers;
        private float _temperatura;

        public WeatherStation()
        { 
            _observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers!)
            {
                observer.Update(_temperatura);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers!.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers?.Remove(observer);
        }

        internal void SetTemperature(float temperatura)
        {
            _temperatura = temperatura;
            NotifyObservers();
        }
    }
}
