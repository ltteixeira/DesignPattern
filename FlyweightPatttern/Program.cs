using System;

namespace FlyweightPatttern
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PointService(new PointIconFactory());

            foreach (var point in service.getPoints())
                point.draw();

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
