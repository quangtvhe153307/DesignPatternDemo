using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
    public class WildDog : IDog
    {
        public void Action()
        {
            Console.WriteLine("Wild dog action");
        }

        public void Speak()
        {
            Console.WriteLine("Wild dog speak");
        }
    }
}
