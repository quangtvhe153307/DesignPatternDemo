using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Receiver2 : IReceiver
    {
        private int myNumber;
        public int MyNumber { get { return myNumber; } set { myNumber = value; } }

        public Receiver2()
        {
            MyNumber = 75;
        }
        public void Add2ToNumber()
        {
            Console.WriteLine("Begin add 2 to number");
            int preNumber = myNumber;
            myNumber += 2;
            Console.WriteLine("{0} + 2 = {1}", preNumber, myNumber);
        }

        public void Subtract2ToNumber()
        {
            Console.WriteLine("Begin subtract 2 to number");
            if (myNumber > 75)
            {
                int preNumber = myNumber;
                myNumber -= 2;
                Console.WriteLine("{0} - 2 = {1}", preNumber, myNumber);
            } else
            {
                Console.WriteLine("My number can not be less than 75");
                Console.WriteLine("nothing more to undo");
            }
        }

        public void OptionalTaskPriorProcessing()
        {
            Console.WriteLine("Optional Task Prior Processing");
        }

        public void OptionalTaskPostProcessing()
        {
            Console.WriteLine("Optional Task Post Processing");
        }
    }
}
