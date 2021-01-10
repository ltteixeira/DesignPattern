namespace ObserverPattern
{
    public class DataSource : Subject
    {
        private int _valor;
        public int valor
        {
            get { return _valor; }
            set
            {
                _valor = value;
                notifyObservers();
                               

                //Push Style of communication
                //notifyObservers(_valor);
            }
        }
    }
}
