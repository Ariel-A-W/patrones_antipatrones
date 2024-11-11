namespace GoF.Creational.Prototype
{
    internal class Rectangulo : IPrototype<Rectangulo>
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Color { get; set; }

        public Rectangulo(int width, int height, string? color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public Rectangulo Clone()
        {
            return new Rectangulo(this.Width, this.Height, this.Color);
        }

        public void ShowInformacion()
        {
            Console.WriteLine($"Rectángulo: Ancho: {Width} Alto {Height} Color {Color}");
        }
    }
}
