using AdapterPattern.avaFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class CaramelAdapter : Caramel, IFilter
    {
        // Class to abording Inheritance concept - Not is better aproach

        public void apply(Image image)
        {
            init();
            render(image);
        }
    }
}
