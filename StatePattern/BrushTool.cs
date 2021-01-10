using System;

namespace StatePattern
{
    public class BrushTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
