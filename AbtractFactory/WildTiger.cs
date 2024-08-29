using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
    public class WildTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("Wild tiger action");
        }

        public void Speak()
        {
            Console.WriteLine("Wild tiger speak");
        }
    }
}
