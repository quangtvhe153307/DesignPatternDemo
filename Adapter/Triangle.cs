using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Triangle : TriangleInterface
    {
        public double baseT;
        public double height;

        public Triangle(double baseT, double height)
        {
            this.baseT = baseT;
            this.height = height;
        }

        public void AboutTriangle()
        {
            Console.WriteLine("This is actually a triangle");
        }

        public double CalculateAreaOfTriangle()
        {
            return baseT * height / 2;
        }
    }
}
