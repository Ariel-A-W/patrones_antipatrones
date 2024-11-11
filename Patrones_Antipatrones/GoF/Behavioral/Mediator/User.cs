namespace GoF.Behavioral.Mediator
{
    public abstract class User
    {
        protected IChatMediator? _mediator;
        protected string? _name;

        public User(IChatMediator? mediator, string? name)
        {
            _mediator = mediator;
            _name = name;
        }

        public abstract void EnviarMensaje(string mensaje);
        public abstract void RecibirMensaje(string mensaje);
    }
}
