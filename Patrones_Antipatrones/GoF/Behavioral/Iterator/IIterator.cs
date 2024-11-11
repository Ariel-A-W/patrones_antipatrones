namespace GoF.Behavioral.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
        void Reset();
    }
}