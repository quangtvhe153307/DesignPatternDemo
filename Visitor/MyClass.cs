using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class MyClass : IOriginalInterface
    {

        private int initialValue = 5;
        public int InitialValue { get { return initialValue; } set { initialValue = value; } }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Initial value: {0}", initialValue);
            visitor.Visit(this);
            Console.WriteLine("Initial value after visit: {0}", initialValue);
        }
    }
}
