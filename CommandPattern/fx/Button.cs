namespace CommandPattern.fx
{
    public class Button
    {
        public string label { get; set; }

        private ICommand _command { get; set; }

        public Button(ICommand command)
        {
            _command = command;
        }

        public void click()
        {
            _command.execute();
        }
    }
}
