namespace Patrones_Antipatrones.SOLID.DIP.Antipatron;

public class SMSService
{
    public void SendSMS(string message)
    { 
        Console.WriteLine($" Enviando SMS: {message}");
    }
}
