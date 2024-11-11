namespace GoF.Structural.Decorator
{
    public class BasicoNotificador : INotificador
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando una notificación básica. {mensaje}");
        }
    }
}
