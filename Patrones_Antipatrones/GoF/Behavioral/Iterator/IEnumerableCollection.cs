namespace GoF.Behavioral.Iterator
{
    public interface IEnumerableCollection<T>
    {
        IIterator<T> CreateIterator();
    }
}
