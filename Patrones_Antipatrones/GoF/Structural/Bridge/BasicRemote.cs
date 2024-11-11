namespace GoF.Structural.Bridge
{
    public class BasicRemote : RemoteControl
    {
        public BasicRemote(IDevice device) : base(device) { }

        public override void TogglePower()
        {
            Console.WriteLine("Basic Remote: Toggle Power");
            _device!.PowerOn();
        }

        public override void VolumenDown()
        {
            Console.WriteLine("Basic Remote: Volumne Down");
            _device!.SetVolumen(5);
        }

        public override void VolumenUp()
        {
            Console.WriteLine("Basic Remote: Volumne Up");
            _device!.SetVolumen(10);
        }
    }
}
