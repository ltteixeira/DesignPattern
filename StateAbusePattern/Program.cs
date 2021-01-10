using System;

namespace StateAbusePattern
{
    class Program
    {
        static void Main(string[] args)
        {


            var stopwatch = new Stopwatch();
            stopwatch.click();
            stopwatch.click();
            stopwatch.click();



            Console.ReadKey();
        }
    }
}
