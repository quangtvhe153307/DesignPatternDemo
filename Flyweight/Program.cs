namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            RobotFactory factory = new RobotFactory();

            IRobot shape;

            for (int i = 0; i < 2; i++)
            {
                shape = factory.GetRobotFromFactory("small");
                shape.SetColor(GetRandomColor());
                shape.Print();
            }

            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                shape = factory.GetRobotFromFactory("large");
                shape.SetColor(GetRandomColor());
                shape.Print();
            }

            Console.WriteLine("Number objects created: {0}", factory.TotalObjectsCreated());

        }

        private static string GetRandomColor()
        {
            Random random = new Random();
            if(random.Next(100) % 2 == 0 )
            {
                return "red";
            }
            return "green";
        }
    }
}
