namespace MediatorPattern
{
    public class TextBox : UIControl
    {
        private string _content;

        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string content
        {
            get => _content;
            set
            {
                _content = value;
                owner.Changed(this);
            }
        }
    }
}
