using System.Collections.Generic;

namespace FlyweightPatttern
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

        public PointIcon getPointIcon(PointType pointType)
        {
            if (!icons.ContainsKey(pointType))
            {
                var icon = new PointIcon(pointType, null);
                icons.Add(pointType, icon);
            }

            return icons[pointType];
        }
    }
}
