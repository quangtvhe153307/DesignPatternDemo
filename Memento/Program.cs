namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Originator originator = new Originator();
            originator.State = "Initial state";

            Memento mementoObject = originator.GetMemento();

            originator.State = "Intermediary state";
            originator.RevertToState(mementoObject);

            Console.ReadKey();
        }
    }
}
