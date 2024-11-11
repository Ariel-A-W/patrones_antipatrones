namespace GoF.Structural.Proxy
{
    public class ApplicacionProxy
    {
        public void Test()
        {
            IImage image1 = new ProxyImage("foto1.jpg");
            IImage image2 = new ProxyImage("foto2.jpg");

            // La imagen se carga y se muestra solo cuando se llama a Display
            image1.Display(); // Carga y muestra "foto1.jpg"
            image1.Display(); // Muestra "foto1.jpg" sin cargar nuevamente

            image2.Display(); // Carga y muestra "foto2.jpg"
            image2.Display(); // Muestra "foto2.jpg" sin cargar nuevamente
        }
    }
}
