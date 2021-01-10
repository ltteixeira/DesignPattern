namespace CommandPattern.editor
{
    public class HtmlDocument
    {
        public string content { get; set; }

        public void makeBold() => content = $"<b>{content}</b>";
    }
}
