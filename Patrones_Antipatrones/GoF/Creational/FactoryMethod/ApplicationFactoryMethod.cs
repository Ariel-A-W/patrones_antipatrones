namespace GoF.Creational.FactoryMethod
{
    public class ApplicationFactoryMethod
    {
        public void Test()
        {
            DocumentCreator creator;

            // Crear un documento PDF
            creator = new PDFDocumentCreator();
            creator.OpenDocument();
            creator.CloseDocument();

            // Crear un docuemnto Word
            creator = new WordDocumentCreator();
            creator.OpenDocument();
            creator.CloseDocument();

            // Crear un documento Excel
            creator = new ExcelDocumentCreator();
            creator.OpenDocument();
            creator.CloseDocument();
        }
    }
}
