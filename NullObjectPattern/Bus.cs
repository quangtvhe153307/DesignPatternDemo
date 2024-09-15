using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public class Bus : IVehicle
    {
        public static int busCount = 0;

        public Bus()
        {
            busCount++;
        }

        public void Travel()
        {
            Console.WriteLine("Traveeling by bus");
        }
    }
}
