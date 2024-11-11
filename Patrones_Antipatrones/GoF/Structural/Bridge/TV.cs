namespace GoF.Structural.Bridge
{
    public class TV : IDevice
    {
        public void PowerOff()
        {
            Console.WriteLine("TV es Off");
        }

        public void PowerOn()
        {
            Console.WriteLine("TV es On");
        }

        public void SetVolumen(int porcentaje)
        {
            Console.WriteLine($"La TV tiene el nivel de volumen a {porcentaje}%");
        }
    }
}
