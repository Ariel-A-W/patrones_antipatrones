namespace GoF.Behavioral.TemplatedMethod
{
    public class PDFDocumentProcessor : DocumentProcessor
    {
        protected override void CloseDcoument()
        {
            Console.WriteLine("Cerrando el documento PDF");
        }

        protected override void OpenDcoument()
        {
            Console.WriteLine("Abriendo el documento PDF");
        }

        protected override void ReadDcoument()
        {
            Console.WriteLine("Leyendo el documento PDF");
        }
    }
}
