namespace GoF.Structural.Facade
{
    public class VideoPlayer
    {
        public void Play(string archivo)
        {
            Console.WriteLine($"Reproduciendo el archivo de vídeo: {archivo}");
        }
    }
}
