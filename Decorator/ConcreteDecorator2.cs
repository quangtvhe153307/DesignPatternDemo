using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecorator2 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            PaintTheHouse();
        }

        private void PaintTheHouse()
        {
            Console.WriteLine("The house is painted");
        }
    }
}
