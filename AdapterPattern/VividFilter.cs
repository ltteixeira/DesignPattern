using System;

namespace AdapterPattern
{
    public class VividFilter : IFilter
    {
        public void apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter");
        }
    }
}
