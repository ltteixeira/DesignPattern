using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageStore = new ImageStorage();

            imageStore.store("a", new JpegCompressor(), new BlackAndWhiteFilter());

            imageStore.store("b", new PngCompressor(), new BlackAndWhiteFilter());

            Console.ReadKey();
        }
    }
}
