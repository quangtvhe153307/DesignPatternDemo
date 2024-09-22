using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeaksExample
{
    public class SimpleEventClass : IDisposable
    {
        public int Id { get; set; }
        public MyDelegate SimpleDelegate;
        public bool disposed = false;

        public SimpleEventClass()
        {
            SimpleDelegate += new MyDelegate(PrintText);
        }

        public string PrintText(string text)
        {
            return text;
        }

        public void Dispose()
        {
            Dispose(true);
        }
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.SimpleDelegate != null)
                {
                    SimpleDelegate -= new MyDelegate(PrintText);
                    Console.WriteLine("Unsubcribe printtext");
                    disposed = true;
                }
            }
        }

        ~SimpleEventClass()
        {
            Dispose(false);
        }
    }
}
