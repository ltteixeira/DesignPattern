using System;

namespace ChainOfResponsibillity
{
    class Program
    {
        static void Main(string[] args)
        {
            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);
            var server = new WebServer(authenticator);

            server.handle(new HttpRequest("admin", "1234"));

            Console.ReadKey();
        }
    }
}
