namespace GoF.Creational.Prototype
{
    public class Circulo : IPrototype<Circulo>
    {
        public int Radio {  get; set; }
        public string? Color { get; set; }

        public Circulo(int radio, string color)
        {
            Radio = radio;
            Color = color; 
        }

        public Circulo Clone()
        {
            return new Circulo(this.Radio, this.Color!);
        }

        public void ShowInformacion()
        {
            Console.WriteLine($"Circulo: Radio: {Radio}, Color = {Color}");
        }
    }
}
