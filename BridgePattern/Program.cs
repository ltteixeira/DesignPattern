using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new AdvancedRemoteControl(new SamsungTv());
            remoteControl.turnOn();

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
