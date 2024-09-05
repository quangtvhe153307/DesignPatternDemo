namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Invoker invoker = new Invoker();

            IReceiver receiver = new Receiver1();
            ICommand command = new AdditionCommand(receiver);

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            invoker.ExecuteCommand();
            invoker.UnDoCommand();
            invoker.UnDoCommand();
            invoker.UnDoCommand();

            receiver = new Receiver2();
            command = new AdditionCommand(receiver);
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            invoker.ExecuteCommand();
            invoker.UnDoCommand();
            invoker.UnDoCommand();
            invoker.UnDoCommand();
        }
    }
}
