using AdapterPattern.avaFilters;

namespace AdapterPattern
{
    public class CaramelFilter : IFilter
    {
        // Class to abording Composition concept - Is better aproach

        private Caramel caramel;

        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }

        public void apply(Image image)
        {
            caramel.init();
            caramel.render(image);
        }
    }
}
