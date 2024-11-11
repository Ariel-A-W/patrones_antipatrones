namespace Patrones_Antipatrones.AntipatronesPatrones.ReinventingWheel.Patron;

public class ClienteSingletonPatron
{
    private static readonly Lazy<ClienteSingletonPatron> _instancia 
        = new Lazy<ClienteSingletonPatron>(()
            => new ClienteSingletonPatron());

    private ClienteSingletonPatron() { }

    public static ClienteSingletonPatron Instancia 
        => _instancia.Value;
}
