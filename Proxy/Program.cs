namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.DoSomeWork();
            Console.ReadKey();
        }
    }
}
