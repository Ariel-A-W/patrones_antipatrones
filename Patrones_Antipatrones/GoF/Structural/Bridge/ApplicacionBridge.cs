namespace GoF.Structural.Bridge
{
    public class ApplicacionBridge
    {
        public void Test()
        {
            IDevice tv = new TV();
            RemoteControl basicRemote = new BasicRemote(tv);
            basicRemote.TogglePower();
            basicRemote.VolumenUp();
            basicRemote.VolumenDown();

            IDevice radio = new Radio();
            RemoteControl advancedRemote = new AdvancedRemote(radio);
            advancedRemote.TogglePower();
            advancedRemote.VolumenUp();
            advancedRemote.VolumenDown();
            ((AdvancedRemote)advancedRemote).Mute();
        }
    }
}
