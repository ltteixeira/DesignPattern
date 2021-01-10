namespace FlyweightPatttern
{
    public class PointIcon
    {
        public readonly PointType type; // 4 bytes
        private readonly byte[] icon; // 20 KB -> 20 MB

        public PointIcon(PointType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }
    }
}
