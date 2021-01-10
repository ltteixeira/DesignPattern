using System;

namespace ProxyPattern
{
    public class EbookProxy : IEbook
    {
        private string fileName;
        private RealEbook ebook;

        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void show()
        {
            if (ebook == null)
                ebook = new RealEbook(fileName);

            ebook.show();
        }

        public string getFileName()
        {
            return fileName;
        }
    }
}
