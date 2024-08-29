using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
    public class PetDog : IDog
    {
        public void Action()
        {
            Console.WriteLine("Pet dog action");
        }

        public void Speak()
        {
            Console.WriteLine("Pet dog speak");
        }
    }
}
