namespace GoF.Creational.Builder
{
    public class Vehiculo
    {
        public string? Motor { get; set; }
        public int Ruedas { get; set; } 
        public bool GPS { get; set; }

        public void ShowInformacion()
        {
            Console.WriteLine($"Motor: {Motor}");
            Console.WriteLine($"Ruedas: {Ruedas}");
            Console.WriteLine($"GPS: {GPS}");
        }
    }
}
