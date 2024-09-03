using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject : ISubject
    {
        private int flag;
        private List<IObserver> obServerList = new();
        public int Flag
        {
            get 
            { 
                return flag; 
            } 
            set
            {
                flag = value;
                NotifyAllObservers(flag);
            }
        }

        public void Register(IObserver observer)
        {
            obServerList.Add(observer);
        }

        public void NotifyAllObservers(int value)
        {
            foreach (var item in obServerList)
            {
                item.Update(value);
            }
        }

        public void Unregister(IObserver observer)
        {
            obServerList.Remove(observer);
        }
    }
}
