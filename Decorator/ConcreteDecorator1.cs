using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecorator1 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine("New floor added");
        }
    }
}
