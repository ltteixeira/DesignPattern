using System;

namespace BridgePattern
{
    public class SonyTv : IDevice
    {
        public void turnOn()
        {
            Console.WriteLine("Sony: turnOn");
        }

        public void turnOff()
        {
            Console.WriteLine("Sony: turnOff");
        }

        public void setChannel(int number)
        {
            Console.WriteLine("Sony: setChannel");
        }
    }
}
