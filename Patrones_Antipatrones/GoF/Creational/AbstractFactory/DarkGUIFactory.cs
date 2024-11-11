namespace GoF.Creational.AbstractFactory
{
    public class DarkGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ITextBox CreateTextBox()
        {
            return new DarkTextBox();
        }
    }
}
