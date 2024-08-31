using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class ElectricGoods
    {
        private IState state;
        public IState State { get { return state; } set { this.state = value; } }
        public abstract void MoveToCurrentState();
    }
}
