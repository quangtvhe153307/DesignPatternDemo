namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVisitor visitor = new Visitor();
            IOriginalInterface originalInterface = new MyClass();
            originalInterface.Accept(visitor);
        }
    }
}
