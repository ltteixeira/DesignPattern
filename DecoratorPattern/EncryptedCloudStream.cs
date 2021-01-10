namespace DecoratorPattern
{
    public class EncryptedCloudStream : IStream
    {
        private IStream stream;

        public EncryptedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
            var encrypted = encrypt(data);

            stream.write(encrypted);
        }

        private string encrypt(string data)
        {
            return "@#%¨¨%$#%$#$$#%@@@$##";
        }
    }
}
