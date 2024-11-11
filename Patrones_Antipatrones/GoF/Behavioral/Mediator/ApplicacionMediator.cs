namespace GoF.Behavioral.Mediator
{
    public class ApplicacionMediator
    {
        public void Test()
        {
            // Crear el mediador
            IChatMediator chatMediator = new ChatMediator();

            // Crear usuarios
            User user1 = new ConcreteUser(chatMediator, "Alice");
            User user2 = new ConcreteUser(chatMediator, "Bob");
            User user3 = new ConcreteUser(chatMediator, "Charlie");

            // Registrar usuarios en el mediador
            chatMediator.RegistrarUsuario(user1);
            chatMediator.RegistrarUsuario(user2);
            chatMediator.RegistrarUsuario(user3);

            // Enviar mensajes
            user1.EnviarMensaje("¡Hola a todo el mundo!");
            user2.EnviarMensaje("¡Hola Alicia!");
            user3.EnviarMensaje("¡Buenos días!");
        }
    }
}
