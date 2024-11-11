namespace GoF.Creational.AbstractFactory
{
    public class DarkTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Renderizar el TextBox de Oscuridad");
        }
    }
}
