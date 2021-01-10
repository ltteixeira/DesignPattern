using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new BrowseHistory();

            history.push("a");
            history.push("b");
            history.push("c");

            IIterator iterator = history.createIterator();

            while (iterator.hasNext())
            {
                var url = iterator.current();
                Console.WriteLine(url);
                iterator.next();
            }
            
            Console.ReadKey();
        }
    }
}
