namespace GoF.Creational.AbstractFactory
{
    public class ApplicationAbstractFactory
    {
        public void Test()
        {
            // Crear GUI con tema Light
            IGUIFactory lightFactory = new LightGUIFactory();
            IButton lightButton = lightFactory.CreateButton();
            ITextBox lightTextBox = lightFactory.CreateTextBox();
            lightButton.Render();
            lightTextBox.Render();

            // Crear GUI con tema Dark
            IGUIFactory darkFactory = new DarkGUIFactory();
            IButton darkButton = darkFactory.CreateButton();
            ITextBox darkTextBox = darkFactory.CreateTextBox();
            darkButton.Render();
            darkTextBox.Render();
        }
    }
}