namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype design pattern");
            BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };
            BasicCar ford_base = new Ford("Yellow Ford") { Price = 200000 };

            BasicCar c1 = nano_base.Clone();
            c1.Price = nano_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is {0}, and its price is {1}", c1.ModelName, c1.Price);

            c1 = ford_base.Clone();
            c1.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is {0}, and its price is {1}", c1.ModelName, c1.Price);
        }
    }
}
