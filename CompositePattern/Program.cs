using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group();
            group1.add(new Shape()); // square
            group1.add(new Shape()); // square

            var group2 = new Group();
            group2.add(new Shape()); // circle
            group2.add(new Shape()); // circle

            var group = new Group();
            group.add(group1);
            group.add(group2);
            group.render();
            group.move();

            Console.ReadKey();
        }
    }
}
