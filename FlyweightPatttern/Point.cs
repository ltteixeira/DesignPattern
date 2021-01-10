using System;

namespace FlyweightPatttern
{
    public class Point
    {
        private int x; // 4 bytes
        private int y; // 4 bytes
        private PointIcon pointIcon;

        public Point(int x, int y, PointIcon pointIcon)
        {
            this.x = x;
            this.y = y;
            this.pointIcon = pointIcon;
        }

        public void draw()
        {
            Console.WriteLine($"{pointIcon.type} at ({x}, {y})");
        }
    }
}
