using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsibility
{
    public class Message
    {
        public Priority Priority { get; set; }
        public string Text { get; set; }

        public Message(Priority priority, string text)
        {
            Priority = priority;
            Text = text;
        }
    }
}
