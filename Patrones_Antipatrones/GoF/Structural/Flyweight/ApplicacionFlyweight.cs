namespace GoF.Structural.Flyweight
{
    public class ApplicacionFlyweight
    {
        public void Test()
        {
            CharacterFactory factory = new CharacterFactory();

            string document = "Hola Mundo";
            string fontFamily = "Arial";
            int fontSize = 12;
            string color = "Negro";

            foreach (char symbol in document)
            {
                ICharacter character = factory.GetCharacter(symbol);
                character.Draw(fontFamily, fontSize, color);
            }
        }
    }
}
