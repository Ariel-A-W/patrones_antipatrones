namespace GoF.Creational.AbstractFactory
{
    public class DarkButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Renderizar el Botón de Oscuridad.");
        }
    }
}
