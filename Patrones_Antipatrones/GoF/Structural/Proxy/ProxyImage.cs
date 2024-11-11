namespace GoF.Structural.Proxy
{
    public class ProxyImage : IImage
    {
        private RealImage? _realImage;
        private string _archivo;

        public ProxyImage(string archivo)
        { 
            _archivo = archivo;
        }

        public void Display()
        {
            if (_realImage == null)
                _realImage = new RealImage(_archivo); 

            _realImage.Display();
        }
    }
}
