namespace Patrones_Antipatrones.SOLID.DIP.Patron;

public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Enviando un Email {message}");
    }
}
