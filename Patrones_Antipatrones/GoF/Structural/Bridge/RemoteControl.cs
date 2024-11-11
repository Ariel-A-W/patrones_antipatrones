namespace GoF.Structural.Bridge
{
    public abstract class RemoteControl
    {
        protected IDevice? _device;

        protected RemoteControl(IDevice device)
        {
            this._device = device;
        }

        public abstract void TogglePower();
        public abstract void VolumenUp();
        public abstract void VolumenDown();
    }
}
