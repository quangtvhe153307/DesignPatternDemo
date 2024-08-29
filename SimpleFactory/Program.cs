namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISimpleFactory factory = new SimpleFactory();
            IAnimal preferType = null;

            preferType = factory.CreateAnimal();
            preferType.Speak();
            preferType.Action();

            preferType = factory.CreateAnimal();
            preferType.Speak();
            preferType.Action();

            Console.ReadKey();
        }
    }
}
