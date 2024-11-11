namespace GoF.Behavioral.Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IChatMediator? mediator, string? name) 
            : base(mediator, name) { }

        public override void EnviarMensaje(string mensaje)
        {
            Console.WriteLine($"{_name} enviado: {mensaje}");
        }

        public override void RecibirMensaje(string mensaje)
        {
            Console.WriteLine($"{_name} recibido: {mensaje}");
        }
    }
}
