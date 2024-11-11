namespace Patrones_Antipatrones.SOLID.DIP.Antipatron;

public class NotificacionesService
{
    private readonly EmailService _emailService; 
    private readonly SMSService _smsService;

    public NotificacionesService()
    {
        _emailService = new EmailService();
        _smsService = new SMSService();
    }

    public void NotificacionPorEmail(string message)
    {
        _emailService.SendEmail(message);
    }

    public void NotificacionPorSMS(string message)
    {
        _smsService.SendSMS(message);
    }
}
