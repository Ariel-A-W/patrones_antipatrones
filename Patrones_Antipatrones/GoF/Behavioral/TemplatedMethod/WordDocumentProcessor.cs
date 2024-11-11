namespace GoF.Behavioral.TemplatedMethod
{
    public class WordDocumentProcessor : DocumentProcessor
    {
        protected override void CloseDcoument()
        {
            Console.WriteLine("Cerrando el documento Word");
        }

        protected override void OpenDcoument()
        {
            Console.WriteLine("Abriendo el documento Word");
        }

        protected override void ReadDcoument()
        {
            Console.WriteLine("Leyendo el documento Word");
        }
    }
}
