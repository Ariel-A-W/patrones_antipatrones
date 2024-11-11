namespace GoF.Behavioral.Iterator
{
    public class ApplicacionIterator
    {
        public void Test()
        {
            // Crear la colección de libros
            BookCollection books = new BookCollection();
            books.AddBook(new Book("Harry Potter"));
            books.AddBook(new Book("El Fantásma de la Ópera"));
            books.AddBook(new Book("1984"));
            books.AddBook(new Book("Moby-Dick"));

            // Crear el iterador
            IIterator<Book> iterator = books.CreateIterator();

            // Recorrer la colección de libros
            Console.WriteLine("Colección de libros clásicos:");
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Title);
            }
        }
    }
}
