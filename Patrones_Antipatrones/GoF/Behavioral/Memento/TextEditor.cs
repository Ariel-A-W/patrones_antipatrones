using static System.Net.Mime.MediaTypeNames;

namespace GoF.Behavioral.Memento
{
    public class TextEditor
    {
        private string? _text;

        public void Escribir(string text)
        {
            _text = text;
            Console.WriteLine($"Texto actual: {text}");
        }

        public TextMemento Guardar()
        {
            Console.WriteLine("Guardar el texto.");
            return new TextMemento(_text!);
        }

        public void Recuperar(TextMemento memento)
        {
            _text = memento.Text;
            Console.WriteLine($"Restaurar texto: {_text}");
        }
    }
}
