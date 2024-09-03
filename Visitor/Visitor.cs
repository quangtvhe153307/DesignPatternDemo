using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Visitor : IVisitor
    {
        public void Visit(MyClass myClass)
        {
            Console.WriteLine("Enter visit method.");
            myClass.InitialValue = 100;
            Console.WriteLine("Exit visit method.");
        }
    }
}
