using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet();
            var sheet2 = new SpreadSheet();
            var chart = new Chart();

            dataSource.addObserver(sheet1);
            dataSource.addObserver(sheet2);
            dataSource.addObserver(chart);

            dataSource.valor = 1;

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
