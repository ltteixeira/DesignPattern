using System;

namespace StatePattern
{
    public class SelectionTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }
    }
}
