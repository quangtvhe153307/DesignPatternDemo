namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IAnimal animal = null;
            IFactory dogFactory = new DogFactory();
            animal = dogFactory.CreateAnimal();
            animal.Action();
            animal.Speak();

            IFactory tigerFactory = new TigerFactory();
            animal = tigerFactory.CreateAnimal();
            animal.Speak();
            animal.Action();

            Console.ReadKey();
        }
    }
}
