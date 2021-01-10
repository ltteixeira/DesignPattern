using System;

namespace StatePattern
{
    public class EraserTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Eraser icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}
