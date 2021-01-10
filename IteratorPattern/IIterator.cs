namespace IteratorPattern
{
    public interface IIterator
    {
        bool hasNext();
        string current();
        void next();
    }
}
