using System;

namespace BridgePattern
{
    public class SamsungTv : IDevice
    {
        public void turnOn()
        {
            Console.WriteLine("Samsung: turnOn");
        }

        public void turnOff()
        {
            Console.WriteLine("Samsung: turnOff");
        }

        public void setChannel(int number)
        {
            Console.WriteLine("Samsung: setChannel");
        }
    }
}
