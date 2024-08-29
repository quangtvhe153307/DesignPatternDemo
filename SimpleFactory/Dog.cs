using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Dog : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Dog prefer barking");
        }

        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-wow");
        }
    }
}
