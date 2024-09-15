using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public class Train : IVehicle
    {
        public static int trainCount = 0;

        public Train()
        {
            trainCount++;
        }

        public void Travel()
        {
            Console.WriteLine("Traveling by train");
        }
    }
}
