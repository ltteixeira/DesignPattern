using System;

namespace StrategyPattern
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void apply(string fileName) => Console.WriteLine("Applying B&W filter");
    }
}
