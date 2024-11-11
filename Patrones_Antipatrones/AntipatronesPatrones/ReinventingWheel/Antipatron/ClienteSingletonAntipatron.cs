namespace Patrones_Antipatrones.AntipatronesPatrones.ReinventingWheel.Antipatron;

public class ClienteSingletonAntipatron
{
    private static ClienteSingletonAntipatron _instancia;

    private ClienteSingletonAntipatron() { }

    public static ClienteSingletonAntipatron GetInstancia()
    {
        if (_instancia == null)
        {
            _instancia = new ClienteSingletonAntipatron();
        }
        return _instancia;
    }
}
