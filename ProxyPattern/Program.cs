using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            string[] fileNames = { "a", "b", "c" };

            foreach (var fileName in fileNames)
                library.add(new LogginEbookProxy(fileName));

            library.openEbook("a");
            library.openEbook("b");

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
