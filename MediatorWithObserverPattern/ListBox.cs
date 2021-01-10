namespace MediatorWithObserverPattern
{
    public class ListBox : UIControl
    {
        private string _selection;

        public string selection
        {
            get => _selection;
            set
            {
                _selection = value;
                notifyEventHandlers();
            }
        }
    }
}
