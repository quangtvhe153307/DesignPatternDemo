using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class BasicCar
    {
        public string ModelName { get; set; }
        public int Price { get; set; }

        public abstract BasicCar Clone();

        public static int SetPrice()
        {
            Random r = new Random();
            return r.Next(200000, 500000);
        }
    }
}
