using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ScienceIterator : IIterator
    {
        private LinkedList<string> subjects;
        private int position;

        public ScienceIterator(LinkedList<string> subjects)
        {
            this.subjects = subjects;
            this.position = 0;
        }

        public string CurrentItem()
        {
            return subjects.ElementAt(position);
        }

        public void First()
        {
            position = 0;
        }

        public bool IsDone()
        {
            return position == subjects.Count;
        }

        public string Next()
        {
            return subjects.ElementAt(position++);
        }
    }
}
