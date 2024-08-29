using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
    public class WildAnimalFactory : IAnimalFactory
    {
        public IDog GetDog()
        {
            return new WildDog();
        }

        public ITiger GetTiger()
        {
            return new WildTiger();
        }
    }
}
