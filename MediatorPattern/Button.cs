namespace MediatorPattern
{
    public class Button : UIControl
    {
        private bool _isEnable;

        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool isEnable
        {
            get { return _isEnable; }
            set
            {
                _isEnable = value;
                owner.Changed(this);
            }
        }
    }
}
