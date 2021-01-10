using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealEbook : IEbook
    {
        private string fileName;

        public RealEbook(string fileName)
        {
            this.fileName = fileName;
            load();
        }

        private void load()
        {
            Console.WriteLine("Loading the ebook " + fileName);
        }

        public void show()
        {
            Console.WriteLine("Showing the ebook " + fileName);
        }

        public string getFileName()
        {
            throw new NotImplementedException();
        }
    }
}
