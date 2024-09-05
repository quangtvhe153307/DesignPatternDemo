using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoker
    {
        private ICommand commandToExecute;
        public void SetCommand(ICommand command)
        {
            this.commandToExecute = command;
        }
        public void ExecuteCommand()
        {
            commandToExecute.Do();
        }
        public void UnDoCommand()
        {
            commandToExecute.Undo();
        }
    }
}
