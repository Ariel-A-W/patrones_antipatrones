namespace GoF.Structural.Decorator
{
    public class NotificadorDecorator : INotificador
    {
        protected INotificador? _notificador;

        public NotificadorDecorator(INotificador notificador)
        { 
            _notificador = notificador;
        }

        public virtual void Enviar(string mensaje)
        {
            _notificador!.Enviar(mensaje);
        }
    }
}
