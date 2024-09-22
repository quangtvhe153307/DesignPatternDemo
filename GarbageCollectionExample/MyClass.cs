using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionExample
{
    public class MyClass : IDisposable
    {
        private int MyInt;
        private double MyDouble;

        public MyClass()
        {
            MyInt = 25;
            MyDouble = 100.5;
        }
        public void ShowMe()
        {
            Console.WriteLine("MyClass.ShowMe()");
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        //public void Dispose()
        //{
        //    GC.SuppressFinalize(this);
        //    Console.WriteLine("Dispose is called");

        //    Console.WriteLine("Total memory: " + GC.GetTotalMemory(false));
        //}
        ~MyClass()
        {
            Console.WriteLine("Destructor is called");
            Console.WriteLine("After this destruction total memory: " + GC.GetTotalMemory(false));

        }
    }
}
