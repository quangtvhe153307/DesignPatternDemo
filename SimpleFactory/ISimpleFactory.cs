using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class ISimpleFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
