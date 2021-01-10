using System;

namespace ObserverPattern
{
    public class Chart : IObserver
    {
        //PULL Style of communication
        //private DataSource dataSource;

        //public Chart(DataSource dataSource)
        //{
        //    this.dataSource = dataSource;
        //}
        //public void update() => Console.WriteLine("Chart got updated: " + dataSource.valor);

        public void update() => Console.WriteLine("Chart got updated");



        //Push Style of communication
        //public void update(int valor) => Console.WriteLine("Chart got updated: " + valor);
    }
}
