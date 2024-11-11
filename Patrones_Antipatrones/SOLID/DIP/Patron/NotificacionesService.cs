namespace Patrones_Antipatrones.SOLID.DIP.Patron;

public class NotificacionesService
{
    public readonly IMessageService _messageService;

    public NotificacionesService(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notificar(string message)
    { 
        _messageService.SendMessage(message);
    }
}
