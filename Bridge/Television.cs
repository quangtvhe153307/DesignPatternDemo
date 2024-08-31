using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Television : ElectricGoods
    {
        public override void MoveToCurrentState()
        {
            Console.Write("Current state of Television: ");
            State.MoveState();
        }
    }
}
