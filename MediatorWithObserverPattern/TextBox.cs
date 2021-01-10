namespace MediatorWithObserverPattern
{
    public class TextBox : UIControl
    {
        private string _content;

        public string content
        {
            get => _content;
            set
            {
                _content = value;
                notifyEventHandlers();
            }
        }
    }
}
