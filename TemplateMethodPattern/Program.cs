using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new TransferMoneyTask();
            task.execute();

            Console.ReadKey();
        }
    }
}
