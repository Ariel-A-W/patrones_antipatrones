namespace GoF.Behavioral.Iterator
{
    public class BookIterator : IIterator<Book>
    {
        private BookCollection? _bookCollection;
        private int _currentIndex = 0;

        public BookIterator(BookCollection bookCollection) 
            => _bookCollection = bookCollection;

        public bool HasNext() 
            => _currentIndex < _bookCollection!.GetBooks().Count;

        public Book Next() 
            => _bookCollection!.GetBooks()[_currentIndex++];

        public void Reset() => _currentIndex = 0;
    }
}
