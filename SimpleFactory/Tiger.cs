using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Tiger : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Tiger prefer hunting");
        }

        public void Speak()
        {
            Console.WriteLine("Tiger says halum.");
        }
    }
}
