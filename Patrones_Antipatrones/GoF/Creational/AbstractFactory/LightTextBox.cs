namespace GoF.Creational.AbstractFactory
{
    public class LightTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Renderizar el TextBox de Luz");
        }
    }
}
