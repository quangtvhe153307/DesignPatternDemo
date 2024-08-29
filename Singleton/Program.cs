namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("First");
            Singleton first = Singleton.Instance;
            Console.WriteLine("Second");
            Singleton Second = Singleton.Instance;
            if(first == Second)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }
        }
    }
}
