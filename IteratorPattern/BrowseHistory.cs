using System.Collections.Generic;
using System.Linq;

namespace IteratorPattern
{
    public class BrowseHistory
    {
        #region << LIST >>

        //private List<string> urls = new List<string>();

        //public void push(string url) => urls.Add(url);

        //public string pop()
        //{
        //    var lastUrl = urls.Last();

        //    urls.Remove(lastUrl);

        //    return lastUrl;
        //}

        //public Iterator createIterator() => new ListIterador(this);


        //public class ListIterador : Iterator
        //{
        //    private BrowseHistory history;
        //    private int index;

        //    public ListIterador(BrowseHistory history)
        //    {
        //        this.history = history;
        //    }

        //    public string current() => history.urls[index];

        //    public bool hasNext() => index < history.urls.Count;

        //    public void next() => index++;
        //}

        #endregion


        #region << ARRAY >>

        private string[] urls = new string[10];
        private int count;

        public void push(string url) => urls[count++] = url;

        public string pop() => urls[--count];

        public IIterator createIterator() => new ArrayIterador(this);


        public class ArrayIterador : IIterator
        {
            private BrowseHistory history;
            private int index;

            public ArrayIterador(BrowseHistory history)
            {
                this.history = history;
            }

            public string current() => history.urls[index];

            public bool hasNext() => index < history.count;

            public void next() => index++;
        }

        #endregion
    }
}
