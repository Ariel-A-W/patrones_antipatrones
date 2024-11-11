namespace Patrones_Antipatrones.SOLID.DIP.Patron;

public class SMSService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Enviando SMS {message}");
    }
}
