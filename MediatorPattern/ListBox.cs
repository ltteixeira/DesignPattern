namespace MediatorPattern
{
    public class ListBox : UIControl
    {
        private string _selection;

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string selection
        {
            get => _selection;
            set
            {
                _selection = value;
                owner.Changed(this);
            }
        }
    }
}
