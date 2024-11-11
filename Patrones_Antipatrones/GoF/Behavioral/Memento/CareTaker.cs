namespace GoF.Behavioral.Memento
{
    public class CareTaker
    {
        private List<TextMemento> 
            _mementos = new List<TextMemento>();
        private TextEditor? _editor;
        private int _currentIndex = 0;

        public CareTaker(TextEditor? editor)
        {
            _editor = editor;
        }
        public void Guardar()
        {
            if (_currentIndex < _mementos.Count - 1)
                _mementos.RemoveRange(
                    _currentIndex + 1, 
                    _mementos.Count - _currentIndex - 1
                );

            _mementos.Add(_editor!.Guardar());
            _currentIndex++;
        }

        public void Deshacer()
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
                _editor!.Recuperar(_mementos[_currentIndex]);
            }
            else
            {
                Console.WriteLine("No se puede deshacer más.");
            }                
        }

        public void Rehacer()
        {
            if (_currentIndex < _mementos.Count - 1)
            {
                _currentIndex++;
                _editor!.Recuperar(_mementos[_currentIndex]);
            }
            else
            {
                Console.WriteLine("No se puede rehacer más.");
            }
        }
    }
}
