using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsibility
{
    public class EmailErrorHandler : IReceiver
    {
        private IReceiver nextReceiver;

        public EmailErrorHandler(IReceiver nextReceiver)
        {
            this.nextReceiver = nextReceiver;
        }

        public bool HandleMessage(Message message)
        {
            if (message.Text.Contains("Email"))
            {
                Console.WriteLine("ErrorMessageHandler processed {0} priority issue: {1}", message.Priority, message.Text);
                return true;
            } else
            {
                if(nextReceiver != null)
                {
                    nextReceiver.HandleMessage(message);
                }
            }
            return false;
        }
    }
}
