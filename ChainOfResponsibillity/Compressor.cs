using System;

namespace ChainOfResponsibillity
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest request)
        {
            Console.WriteLine("Compress");

            return false;
        }
    }
}
