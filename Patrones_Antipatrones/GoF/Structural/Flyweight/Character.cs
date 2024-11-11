namespace GoF.Structural.Flyweight
{
    public class Character : ICharacter
    {
        private readonly char _symbol;

        public Character(char symbol)
        { 
            _symbol = symbol;
        }

        public void Draw(string fontFamily, int fontSize, string color)
        {
            Console.WriteLine(
                $"Dibujando caracteres: '{_symbol}' " +
                $"con la fuente {fontFamily}, tamaño {fontSize}, " +
                $"color: {color}");
        }
    }
}
