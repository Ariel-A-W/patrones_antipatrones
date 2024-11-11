namespace GoF.Behavioral.Iterator
{
    public class BookCollection : IEnumerableCollection<Book>
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book) => _books.Add(book);

        public IIterator<Book> CreateIterator() => new BookIterator(this);

        public List<Book> GetBooks() => _books;
    }
}
