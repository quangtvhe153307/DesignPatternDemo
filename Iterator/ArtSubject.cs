using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ArtSubject : ISubject
    {
        private string[] subjects;

        public ArtSubject()
        {
            this.subjects = new[] {"Art subject 1", "Art subject 2", "Art subject 3", "Art subject 4" };
        }

        public IIterator CreateIterator()
        {
            return new ArtIterator(subjects);
        }
    }
}
