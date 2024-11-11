namespace GoF.Behavioral.Memento
{
    public class ApplicacionMemento
    {
        public void Test()
        {
            TextEditor editor = new TextEditor();
            CareTaker caretaker = new CareTaker(editor);

            // Escribir texto y guardar el estado
            editor.Escribir("Hola, mundo.");
            caretaker.Guardar();

            editor.Escribir("Hola, diseño de patrones.");
            caretaker.Guardar();

            editor.Escribir("Hola, patrón Memento");
            caretaker.Guardar();

            // Deshacer operaciones
            caretaker.Deshacer();
            caretaker.Deshacer();

            // Rehacer operaciones
            caretaker.Rehacer();
        }
    }
}
