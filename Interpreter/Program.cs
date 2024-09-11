namespace Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string inputString;
            Console.WriteLine("Enter a 3 digit number only");
            inputString = Console.ReadLine();

            Context context = new Context(inputString);

            if (context.ValidateUserInputBeforeProceeding(inputString) != 9999)
            {
                List<InputExpression> expTree = new List<InputExpression>();
                expTree.Add(new HundredExpression());
                expTree.Add(new TensExpression());
                expTree.Add(new UnitExpression());

                foreach (var input in expTree)
                {
                    input.Interpreter(context);
                }

                Console.WriteLine("Original input {0} is interpreted as {1}", context.GetInput, context.SetOutput);
            }

            Console.ReadKey();

        }
    }
}
