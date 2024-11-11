namespace GoF.Behavioral.Observer
{
    public class StatisticsDisplay : IObserver
    {
        private List<float> _temperaturas = new List<float>();
        public void Update(float temperatura)
        {
            _temperaturas.Add(temperatura);
            Display();
        }

        public void Display()
        {
            float promedio = _temperaturas.Average();
            Console.WriteLine(
                $"Temperaturas Prom/Max/Min: " +
                $"{promedio}/{_temperaturas.Max()}/{_temperaturas.Min()}"
            );
        }
    }
}
