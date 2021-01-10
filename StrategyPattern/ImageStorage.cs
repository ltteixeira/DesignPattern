namespace StrategyPattern
{
    public class ImageStorage
    {
        public void store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.compress(fileName);
            filter.apply(fileName);
        }
    }
}
