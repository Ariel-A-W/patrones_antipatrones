namespace GoF.Behavioral.Command
{
    public class Light
    {
        public void On() => Console.WriteLine("La Luz está encendida.");

        public void Off() => Console.WriteLine("La Luz está apagada.");
    }
}
