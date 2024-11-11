namespace GoF.Creational.AbstractFactory
{
    public class LightGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ITextBox CreateTextBox()
        {
            return new LightTextBox();
        }
    }
}
