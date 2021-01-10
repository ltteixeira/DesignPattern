using System;

namespace ChainOfResponsibillity
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest request)
        {
            Console.WriteLine("Log");

            return false;
        }
    }
}
