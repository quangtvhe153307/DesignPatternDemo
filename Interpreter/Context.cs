using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Context
    {
        private int getInput;
        private string getStringInput;
        public string setOutput;
        private bool canProceed = false;
        public bool CanProceed {  get { return canProceed; } }
        public int GetInput {  get { return getInput; } }
        public string SetOutput { get { return setOutput; } set { setOutput = value; } }

        public Context(string getStringInput)
        {
            this.getStringInput = getStringInput;
        }

        public int ValidateUserInputBeforeProceeding(string inputString)
        {
            if(int.TryParse(inputString, out getInput))
            {
                Console.WriteLine("You have entered {0}", getInput);

                if(getInput < 100 || getInput > 999)
                {
                    Console.WriteLine("Please enter the number between 100 and 999 and try again.");
                    return -9999;
                }
            }
            canProceed = true;
            return getInput;
        }
    }
}
