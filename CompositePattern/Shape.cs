using System;

namespace CompositePattern
{
    public class Shape  : IComponent
    {
        public void render()
        {
            Console.WriteLine("Render Shape");
        }
        public void move()
        {
            Console.WriteLine("Move Shape");
        }
    }
}
