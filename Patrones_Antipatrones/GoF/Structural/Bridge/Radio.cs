namespace GoF.Structural.Bridge
{
    public class Radio : IDevice
    {
        public void PowerOff()
        {
            Console.WriteLine("La Radio está Off");
        }

        public void PowerOn()
        {
            Console.WriteLine("La Radio está On");
        }

        public void SetVolumen(int porcentaje)
        {
            Console.WriteLine($"La Radio tiene el nivel lde volumen a {porcentaje}%");
        }
    }
}
