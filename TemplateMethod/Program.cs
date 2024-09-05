namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BaseEngineering @base = new ComputerScience();
            @base.Paper();

            @base = new Electronics();
            @base.Paper();

            Console.ReadKey();
        }
    }
}
