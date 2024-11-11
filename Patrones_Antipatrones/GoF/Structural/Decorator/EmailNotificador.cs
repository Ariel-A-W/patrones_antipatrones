namespace GoF.Structural.Decorator
{
    public class EmailNotificador : NotificadorDecorator
    {
        public EmailNotificador(INotificador notificador) : base(notificador) { }

        public override void Enviar(string mensaje)
        {
            base.Enviar(mensaje);
            Console.WriteLine($"Enviando notificación Email: {mensaje}"); 
        }
    }
}
