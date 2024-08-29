using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TigerFactory : IFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
}
