using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface IIterator
    {
        void First();           //reset to first element
        string Next();          //get next element
        bool IsDone();          //end of collection check
        string CurrentItem();   //retrieve current item
    }
}
