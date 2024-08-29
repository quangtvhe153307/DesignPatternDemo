using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Tiger : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Tiger prefer hunt");
        }

        public void Speak()
        {
            Console.WriteLine("Tiger says halum");
        }
    }
}
