using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public class NullVehicle : IVehicle
    {
        private static readonly NullVehicle instance = new NullVehicle();
        public static int nullVehicleCount = 0;
        public static NullVehicle Instance
        {
            get { return instance; }
        }

        public void Travel()
        {

        }
    }
}
