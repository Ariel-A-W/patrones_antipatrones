namespace GoF.Structural.Facade
{
    public class VideoConverter
    {
        public void Convert(string archivo, string formato)
        {
            Console.WriteLine($"Convirtiendo {archivo} al formato {formato}");
        }
    }
}