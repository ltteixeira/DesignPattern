namespace CommandPattern.editor
{
    public interface IUndoableCommand : Command
    {
        void unexecute();
    }
}
