using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
    public interface IAnimalFactory
    {
        public ITiger GetTiger();
        public IDog GetDog();
    }
}
