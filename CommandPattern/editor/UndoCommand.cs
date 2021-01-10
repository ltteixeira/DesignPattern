namespace CommandPattern.editor
{
    public class UndoCommand : Command
    {
        private History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void execute()
        {
            if (history.size() > 0)
                history.pop().unexecute();
        }
    }
}
