namespace GoF.Creational.FactoryMethod
{
    public class WordDocumentCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }
}
