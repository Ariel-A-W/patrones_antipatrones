namespace GoF.Creational.AbstractFactory
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
