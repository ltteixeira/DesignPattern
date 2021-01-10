namespace AdapterPattern
{
    public class ImageView
    {
        private Image image { get; set; }

        public ImageView(Image image)
        {
            this.image = image;
        }

        public void apply(IFilter filter)
        {
            filter.apply(image);
        }
    }
}
