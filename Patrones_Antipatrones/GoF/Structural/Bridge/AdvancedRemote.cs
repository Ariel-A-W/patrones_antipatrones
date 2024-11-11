namespace GoF.Structural.Bridge
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device) { }

        public override void TogglePower()
        {
            Console.WriteLine("Advanced Remote: Toggle Power");
            _device!.PowerOff();
        }

        public override void VolumenDown()
        {
            Console.WriteLine("Advanced Remote: Volumen Down");
            _device!.SetVolumen(15);
        }

        public override void VolumenUp()
        {
            Console.WriteLine("Advanced Remote: Volumen Up");
            _device!.SetVolumen(20);
        }

        public void Mute()
        {
            Console.WriteLine("Advanced Remote: Silencio");
            _device!.SetVolumen(0);
        }
    }
}
