using System;

namespace StrategyPattern
{
    public class PngCompressor : ICompressor
    {
        public void compress(string fileName) => Console.WriteLine("Compressing using PNG");
    }
}
