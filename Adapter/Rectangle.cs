using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Rectangle : RectangleInterface
    {
        public double width;
        public double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public void AboutRectangle()
        {
            Console.WriteLine("This is actually a rectangle");
        }

        public double CalculateAreaOfRectangle()
        {
            return width * height;
        }
    }
}
