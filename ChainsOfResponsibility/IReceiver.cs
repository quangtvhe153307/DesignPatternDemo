using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsibility
{
    public interface IReceiver
    {
        bool HandleMessage(Message message);
    }
}
