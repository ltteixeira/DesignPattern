using System;

namespace DecoratorPattern
{
    public class CloudStream : IStream
    {
        public void write(string data)
        {
            Console.WriteLine("Storing " + data);
        }
    }
}
