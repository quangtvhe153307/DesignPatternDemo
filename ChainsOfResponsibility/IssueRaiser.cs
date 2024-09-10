using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsibility
{
    public class IssueRaiser
    {
        public IReceiver FirstReceiver;
        public IssueRaiser(IReceiver receiver)
        {
            this.FirstReceiver = receiver;
        }
        public void RaiseMessage(Message message)
        {
            if(this.FirstReceiver != null)
            {
                FirstReceiver.HandleMessage(message);
            }
        }
    }
}
