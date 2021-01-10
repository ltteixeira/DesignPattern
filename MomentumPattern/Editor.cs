namespace MomentumPattern
{
    public class Editor
    {
        public string content { get; set; } // private

        public EditorState createState() => new EditorState(content);

        public void restore(EditorState state) => content = state.content;
    }
}
