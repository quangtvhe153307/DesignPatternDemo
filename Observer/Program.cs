namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IObserver observer1 = new Observer1("observer1");
            IObserver observer2 = new Observer2("observer2");

            Subject subject1 = new Subject();
            subject1.Register(observer1);
            subject1.Register(observer2);

            subject1.Flag = 100;

            subject1
                .Unregister(observer2);
            subject1.Flag = 101;
        }
    }
}
