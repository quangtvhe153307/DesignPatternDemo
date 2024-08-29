using System.ComponentModel;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component c = new ConcreteComponent();


            AbstractDecorator decorator1 = new ConcreteDecorator1();
            decorator1.SetTheComponent(c);
            decorator1.MakeHouse();

            AbstractDecorator decorator2 = new ConcreteDecorator2();
            decorator2.SetTheComponent(decorator1);
            decorator2.MakeHouse();
        }
    }
}
