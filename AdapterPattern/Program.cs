using AdapterPattern.avaFilters;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView(new Image());
            imageView.apply(new VividFilter());
            imageView.apply(new CaramelFilter(new Caramel()));

            Console.ReadKey();
        }
    }
}
