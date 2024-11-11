namespace GoF.Structural.Facade
{
    public class ApplicacionFacade
    {
        public void Test()
        {
            VideoFacade videoFacade = new VideoFacade();

            // Cargar y reproducir un video
            videoFacade.LoadAndPlay("ejemplo.mp4");

            // Cargar, convertir y reproducir un video
            videoFacade.LoadConvertAndPlay("ejemplo.mp4", "avi");
        }
    }
}
