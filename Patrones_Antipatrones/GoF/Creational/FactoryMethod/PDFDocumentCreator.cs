namespace GoF.Creational.FactoryMethod
{
    public class PDFDocumentCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new PDFDocument();
        }
    }
}
