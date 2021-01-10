namespace MomentumPattern
{
    public class EditorState
    {
        public string content { get; } // private, final

        public EditorState(string content)
        {
            this.content = content;
        }
    }
}
