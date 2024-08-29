using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Proxy : Subject
    {
        Subject s;

        public override void DoSomeWork()
        {
            if(s == null)
            {
                s = new ConcreteSubject();
            }
            s.DoSomeWork();
        }
    }
}
