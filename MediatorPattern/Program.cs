using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dialog = new ArticlesDialogBox();
            dialog.simulateUserInteraction();

            Console.ReadKey();
        }
    }
}
