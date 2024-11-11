namespace GoF.Creational.AbstractFactory
{
    public class LightButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Renderizar el Botón de Luz");
        }
    }
}
