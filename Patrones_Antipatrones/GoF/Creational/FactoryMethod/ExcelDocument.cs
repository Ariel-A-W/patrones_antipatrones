namespace GoF.Creational.FactoryMethod
{
    public class ExcelDocument : Document
    {
        public override void Close()
        {
            Console.WriteLine("Cerrando el documento de Excel");
        }

        public override void Open()
        {
            Console.WriteLine("Abriendo el documento de Excel");
        }
    }
}
