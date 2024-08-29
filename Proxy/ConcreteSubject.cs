using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("Concrete subject DoSomeWork");
        }
    }
}
