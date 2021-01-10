using System;

namespace ProxyPattern
{
    public class LogginEbookProxy : IEbook
    {
        private string fileName;
        private RealEbook ebook;

        public LogginEbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void show()
        {
            if (ebook == null)
                ebook = new RealEbook(fileName);

            Console.WriteLine("Logging");
            ebook.show();
        }

        public string getFileName()
        {
            return fileName;
        }
    }
}
