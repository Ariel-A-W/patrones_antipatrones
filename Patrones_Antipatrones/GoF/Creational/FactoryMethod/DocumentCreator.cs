namespace GoF.Creational.FactoryMethod
{
    public abstract class DocumentCreator
    {
        public abstract Document CreateDocument();

        public void OpenDocument()
        {
            Document doc = CreateDocument();
            doc.Open();
        }

        public void CloseDocument()
        {
            Document doc = CreateDocument();
            doc.Close();
        }
    }
}
