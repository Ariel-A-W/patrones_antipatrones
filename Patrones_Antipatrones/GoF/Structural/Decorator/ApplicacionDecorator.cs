namespace GoF.Structural.Decorator
{
    public class ApplicacionDecorator
    {
        public void Test()
        {
            // Crear un notificador básico
            INotificador notifier = new BasicoNotificador();

            // Decorar con notificaciones por correo electrónico
            notifier = new EmailNotificador(notifier);

            // Decorar con notificaciones por SMS
            notifier = new SMSNotificador(notifier);

            // Enviar una notificación
            notifier.Enviar("¡Hola Mundo!");
        }
    }
}
