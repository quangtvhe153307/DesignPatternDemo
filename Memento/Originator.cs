using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {
        private string state;
        private Memento memento;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                Console.WriteLine("Current state is {0}", state);
            }
        }

        public Memento GetMemento()
        {
            memento = new Memento();
            memento.State = state;
            return memento;
        }

        public void RevertToState(Memento memento)
        {
            Console.WriteLine("Restoring the previous state");
            this.state = memento.State;
            Console.WriteLine("Current state {0}", state);
        }
    }
}
