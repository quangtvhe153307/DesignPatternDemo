using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Observer2 : IObserver
    {
        private string nameOfObserver;

        public Observer2(string nameOfObserver)
        {
            this.nameOfObserver = nameOfObserver;
        }

        public void Update(int val)
        {
            Console.WriteLine("value {0} is updated in the subject of observer {1}", val, nameOfObserver);
        }
    }
}
