namespace GoF.Creational.FactoryMethod
{
    public class WordDocument : Document
    {
        public override void Close()
        {
            Console.WriteLine("Cerrando el documento de Word");
        }

        public override void Open()
        {
            Console.WriteLine("Abriendo el documento de Word");
        }
    }
}
