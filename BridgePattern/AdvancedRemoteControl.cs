namespace BridgePattern
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base (device)
        {

        }

        public void setChannel(int number)
        {
            device.setChannel(number);
        }
    }
}
