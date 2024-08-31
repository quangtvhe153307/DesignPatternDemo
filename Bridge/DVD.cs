using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class DVD : ElectricGoods
    {
        public override void MoveToCurrentState()
        {
            Console.Write("Current state of DVD: ");
            State.MoveState();
        }
    }
}
