namespace CommandPattern.editor
{
    public class BoldCommand : IUndoableCommand
    {

        private string prevContent { get; set; }
        private HtmlDocument document { get; set; }
        private History history { get; set; }

        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }
        
        public void execute()
        {
            prevContent = document.content;
            document.makeBold();
            history.push(this);
        }

        public void unexecute()
        {
            document.content = prevContent;
        }
    }
}
