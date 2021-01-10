using System.Collections.Generic;

namespace ObserverPattern
{
    // Observable
    public class Subject
    {
        public List<IObserver> observers = new List<IObserver>();

        public void addObserver(IObserver observer) => observers.Add(observer);

        public void removeObserver(IObserver observer) => observers.Remove(observer);

        public void notifyObservers()
        {
            foreach (var observer in observers)
                observer.update();
        }



        //Push Style of communication
        //public void notifyObservers(int valor)
        //{
        //    foreach (var observer in observers)
        //        observer.update(valor);
        //}
    }
}
