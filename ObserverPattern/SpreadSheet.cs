using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class SpreadSheet : IObserver
    {
        //PULL Style of communication
        //private DataSource dataSource;

        //public SpreadSheet(DataSource dataSource)
        //{
        //    this.dataSource = dataSource;
        //}
        //public void update() => Console.WriteLine("SpreadSheet got updated: " + dataSource.valor);



        public void update() => Console.WriteLine("SpreadSheet got updated");



        //Push Style of communication
        //public void update(int valor) => Console.WriteLine("SpreadSheet got updated: " + valor);
    }
}
