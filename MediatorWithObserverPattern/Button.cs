namespace MediatorWithObserverPattern
{
    public class Button : UIControl
    {
        private bool _isEnable;

        public bool isEnable
        {
            get { return _isEnable; }
            set
            {
                _isEnable = value;
                notifyEventHandlers();
            }
        }
    }
}
