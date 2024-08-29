namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RectangleInterface rec = new Rectangle(20, 10);
            Console.WriteLine(rec.CalculateAreaOfRectangle());

            TriangleInterface tri = new Triangle(20, 10);
            Console.WriteLine(tri.CalculateAreaOfTriangle());

            RectangleInterface adapter = new TriangleAdapter(tri);
            Console.WriteLine(adapter.CalculateAreaOfRectangle());
        }
    }
}
