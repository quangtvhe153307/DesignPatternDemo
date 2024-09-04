namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Context context = new Context();
            IChoice choice;
            choice = new FirstChoice();


            context.SetChoice(choice);
            context.ShowChoice();

            choice = new SecondChoice();
            context.SetChoice(choice);
            context.ShowChoice();
        }
    }
}
