namespace GoF.Behavioral.Command
{
    public class ApplicacionCommand
    {
        public void Test()
        {
            // Crear el receptor
            Light livingRoomLight = new Light();

            // Crear comandos
            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);

            // Configurar el invocador
            RemoteControl remote = new RemoteControl();

            // Encender la luz
            remote.SetCommand(lightOn);
            remote.PressButton(); // Output: The light is on

            // Apagar la luz
            remote.SetCommand(lightOff);
            remote.PressButton(); // Output: The light is off            
        }
    }
}
