namespace GoF.Structural.Proxy
{
    public class RealImage : IImage
    {
        private string _archivo;

        public RealImage(string archivo)
        {
            _archivo = archivo;
            LoadFromDisk();

        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Cargando imagen desde el disco: {_archivo}");
        }

        public void Display()
        {
            Console.WriteLine($"Mostrando la imagen: {_archivo}");
        }
    }
}
