using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
    public class PetTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("Pet tiger action");
        }

        public void Speak()
        {
            Console.WriteLine("Pet tiger speak");
        }
    }
}
