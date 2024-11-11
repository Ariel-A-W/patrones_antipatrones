namespace GoF.Structural.Facade
{
    public class VideoFacade
    {
        private VideoLoader? _loader;
        private VideoConverter? _converter;
        private VideoPlayer? _player;

        public VideoFacade()
        {
            _loader = new VideoLoader();
            _converter = new VideoConverter();
            _player = new VideoPlayer();
        }

        public void LoadAndPlay(string archivo)
        {
            _loader!.Load(archivo);
            _player!.Play(archivo);
        }

        public void LoadConvertAndPlay(string archivo, string formato)
        {
            _loader!.Load(archivo);
            _converter!.Convert(archivo, formato);
            _player!.Play(archivo);
        }
    }
}
