using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            storeCreditCard(new EncryptedCloudStream(new CloudStream()));

            Console.WriteLine("");
            Console.ReadKey();
        }

        static void storeCreditCard(IStream stream)
        {
            stream.write("1234-1234-1234-1234");
        }
    }
}
