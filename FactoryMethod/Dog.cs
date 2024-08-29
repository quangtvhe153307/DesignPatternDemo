using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Dog : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Dog prefer bark");
        }

        public void Speak()
        {
            Console.WriteLine("Dog say gau gau");
        }
    }
}
