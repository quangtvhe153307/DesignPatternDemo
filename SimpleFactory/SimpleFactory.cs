using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SimpleFactory : ISimpleFactory
    {
        public override IAnimal CreateAnimal()
        {
            IAnimal animal = null;
            Console.WriteLine("Enter:");
         
            string b1 = Console.ReadLine();
            int input;
            if(int.TryParse(b1, out input))
            {
                switch (input)
                {
                    case 0:
                        animal = new Dog();
                        break;
                    case 1:
                        animal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter either 0 or 1");
                        throw new Exception();
                }
            }
            return animal;
        }
    }
}
