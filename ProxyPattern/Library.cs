using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Library
    {
        private Dictionary<string, IEbook> ebooks = new Dictionary<string, IEbook>();

        public void add(IEbook ebook)
        {
            ebooks.Add(ebook.getFileName(), ebook);
        }

        public void openEbook(string fileName)
        {
            ebooks[fileName].show();
        }
    }
}
