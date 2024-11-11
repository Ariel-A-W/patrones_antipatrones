namespace GoF.Behavioral.Mediator
{
    public class ChatMediator : IChatMediator
    {
        private List<User>? _users;

        public ChatMediator()
        {
            _users = new List<User>();
        }

        public void RegistrarUsuario(User usuario)
        {
            _users!.Add(usuario);
        }

        public void EnviarMensaje(string mensaje, User enviador)
        {
            foreach (var user in _users!)
            {
                if (user != enviador)
                    user.RecibirMensaje(mensaje);
            }
        }
    }
}
