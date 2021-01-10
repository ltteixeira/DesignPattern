using System;

namespace VisitorPattern
{
    public class HighlightOperation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("highlight-heading");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}
