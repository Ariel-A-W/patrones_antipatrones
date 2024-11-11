namespace GoF.Structural.Decorator
{
    public class SMSNotificador : NotificadorDecorator
    {
        public SMSNotificador(INotificador notificador) : base(notificador) { }

        public override void Enviar(string mensaje)
        {
            base.Enviar(mensaje);
            Console.WriteLine($"Enviando notificación SMS: {mensaje}");
        }
    }
}
