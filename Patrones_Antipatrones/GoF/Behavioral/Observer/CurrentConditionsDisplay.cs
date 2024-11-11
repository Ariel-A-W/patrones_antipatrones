namespace GoF.Behavioral.Observer
{
    public class CurrentConditionsDisplay : IObserver
    {
        private float _temparatura; 

        public void Update(float temperatura)
        {
            _temparatura = temperatura;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Condiciones actuales: C° {_temparatura}");
        }
    }
}
