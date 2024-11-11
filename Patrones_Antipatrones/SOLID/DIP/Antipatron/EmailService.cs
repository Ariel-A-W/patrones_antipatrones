namespace Patrones_Antipatrones.SOLID.DIP.Antipatron;

public class EmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Enviando Mensaje: {message}");
    }
}
