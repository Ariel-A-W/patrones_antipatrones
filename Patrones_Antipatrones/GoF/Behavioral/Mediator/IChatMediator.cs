namespace GoF.Behavioral.Mediator
{
    public interface IChatMediator
    {
        void RegistrarUsuario(User usuario);
        void EnviarMensaje(string mensaje, User enviador);
    }
}
