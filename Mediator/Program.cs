namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ConcreteMediator mediator = new ConcreteMediator();

            Friend1 yasuo = new Friend1(mediator, "yasuo");
            Friend2 yone = new Friend2(mediator, "yone");
            Boss irelia = new Boss(mediator, "irelia");
            //Unknown malphite = new Unknown(mediator, "malphite");

            mediator.Friend1 = yasuo;
            mediator.Friend2 = yone;
            mediator.Boss = irelia;

            Console.WriteLine("Communication start");
            yasuo.Send(yone, "hasagi");
            yone.Send(irelia, "hasagi2");
            irelia.Send(yasuo, "ionia still stand");

            yasuo.Status = "Off";
            irelia.Send(yasuo, "ionia still stand");

            yasuo.Status = "On";
            irelia.Send(yasuo, "ionia still stand");

            irelia.Status = "Off";
            yone.Send(yasuo, "Can you please come here");
            yone.Send(irelia, "Can you please come here");

            Console.ReadKey();
        }
    }
}
