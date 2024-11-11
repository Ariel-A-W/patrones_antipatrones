namespace GoF.Structural.Bridge
{
    public interface IDevice
    {
        void PowerOn();
        void PowerOff();
        void SetVolumen(int porcentaje);
    }
}
