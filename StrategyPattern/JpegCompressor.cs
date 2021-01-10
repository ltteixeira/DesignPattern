using System;

namespace StrategyPattern
{
    public class JpegCompressor : ICompressor
    {
        public void compress(string fileName) => Console.WriteLine("Compressing using JPEG");
    }
}
