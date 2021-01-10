namespace StrategyPattern
{
    public interface ICompressor
    {
        // byte[] compress(byte[] image)
        void compress(string fileName);
    }
}
