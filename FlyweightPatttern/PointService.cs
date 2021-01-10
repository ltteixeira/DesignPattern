using System.Collections.Generic;

namespace FlyweightPatttern
{
    public class PointService
    {
        private PointIconFactory pointIconFactory;

        public PointService(PointIconFactory pointIconFactory)
        {
            this.pointIconFactory = pointIconFactory;
        }

        public List<Point> getPoints()
        {          
            List<Point> points = new List<Point>();

            var point = new Point(1, 2, pointIconFactory.getPointIcon(PointType.CAFE));

            points.Add(point);

            return points;
        }
    }
}
