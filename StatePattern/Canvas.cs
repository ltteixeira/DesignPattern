namespace StatePattern
{
    public class Canvas
    {
        public ITool currentTool { get; set; } // private

        public void mouseDown() => currentTool.mouseDown();
        public void mouseUP() => currentTool.mouseUp();
    }
}
