using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();  // OPEN CLOSED PRINCIPLE | Simplicity is the ultimate sophistication

            canvas.currentTool = new SelectionTool();
            canvas.mouseDown();
            canvas.mouseUP();

            canvas.currentTool = new BrushTool();
            canvas.mouseDown();
            canvas.mouseUP();

            canvas.currentTool = new EraserTool();
            canvas.mouseDown();
            canvas.mouseUP();


            Console.ReadKey();
        }
    }
}
