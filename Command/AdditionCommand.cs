using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AdditionCommand : ICommand
    {
        private IReceiver receiver;

        public AdditionCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Do()
        {
            receiver.OptionalTaskPriorProcessing();
            receiver.Add2ToNumber();
            receiver.OptionalTaskPostProcessing();
        }

        public void Undo()
        {
            receiver.OptionalTaskPriorProcessing();
            receiver.Subtract2ToNumber();
            receiver.OptionalTaskPostProcessing();
        }
    }
}
