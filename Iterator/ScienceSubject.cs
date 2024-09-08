using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ScienceSubject : ISubject
    {
        private LinkedList<string> subjects;

        public ScienceSubject()
        {
            this.subjects = new();
            subjects.AddFirst("Science subject 1");
            subjects.AddFirst("Science subject 2");
            subjects.AddFirst("Science subject 3");
            subjects.AddFirst("Science subject 4");
        }

        public IIterator CreateIterator()
        {
            return new ScienceIterator(subjects);
        }
    }
}
