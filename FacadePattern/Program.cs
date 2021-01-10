using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new NotificationService();
            server.send("Hello World", "target");
            
            Console.ReadKey();
        }
    }
}
