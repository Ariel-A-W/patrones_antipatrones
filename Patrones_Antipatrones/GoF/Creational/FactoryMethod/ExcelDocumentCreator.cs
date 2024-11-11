namespace GoF.Creational.FactoryMethod
{
    public class ExcelDocumentCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
