using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface IReceiver
    {
        void Add2ToNumber();
        void Subtract2ToNumber();
        void OptionalTaskPriorProcessing();
        void OptionalTaskPostProcessing();
    }
}
