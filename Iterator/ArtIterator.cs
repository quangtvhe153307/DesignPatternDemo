using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ArtIterator : IIterator
    {
        private string[] subjects;
        private int position;

        public ArtIterator(string[] subjects)
        {
            this.subjects = subjects;
            this.position = 0;
        }

        public string CurrentItem()
        {
            return subjects[position];
        }

        public void First()
        {
            this.position = 0;
        }

        public bool IsDone()
        {
            return position == subjects.Length;
        }

        public string Next()
        {
            return subjects[position++];
        }
    }
}
