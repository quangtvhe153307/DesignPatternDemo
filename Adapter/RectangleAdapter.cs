using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class TriangleAdapter : RectangleInterface
    {
        TriangleInterface triangle;

        public TriangleAdapter(TriangleInterface triangle)
        {
            this.triangle = triangle;
        }

        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }

        public double CalculateAreaOfRectangle()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}
