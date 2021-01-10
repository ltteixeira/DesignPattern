using System;

namespace ChainOfResponsibillity
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest request)
        {
            var isValid = request.userName == "admin" && request.password == "1234";

            Console.WriteLine("Authentication");

            return !isValid;
        }
    }
}
