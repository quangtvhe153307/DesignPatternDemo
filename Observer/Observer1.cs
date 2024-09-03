using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Observer1 : IObserver
    {
        private string nameOfObserver;

        public Observer1(string nameOfObserver)
        {
            this.nameOfObserver = nameOfObserver;
        }

        public void Update(int val)
        {
            Console.WriteLine("{0} has received notification, {1} is updated in the subject", nameOfObserver, val);
        }
    }
}
