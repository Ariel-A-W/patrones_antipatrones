namespace GoF.Creational.FactoryMethod
{
    public class PDFDocument : Document
    {
        public override void Close()
        {
            Console.WriteLine("Cerrando el documento PDF");
        }

        public override void Open()
        {
            Console.WriteLine("Abriendo el documento PDF");
        }
    }
}
