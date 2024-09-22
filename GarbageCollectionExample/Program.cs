namespace GarbageCollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                Console.WriteLine("Maximum Generations of GC: " + GC.MaxGeneration);
                Console.WriteLine("Total Memory: " + GC.GetTotalMemory(false));

                MyClass ob = new();
                Console.WriteLine("ob is in generation: {0}", GC.GetGeneration(ob));
                Console.WriteLine("Now, total memory is: {0}", GC.GetTotalMemory(false));

                Console.WriteLine("Collection occurred in 0th generation: {0}", GC.CollectionCount(0));
                Console.WriteLine("Collection occurred in 1st generation: {0}", GC.CollectionCount(1));
                Console.WriteLine("Collection occurred in 2nd generation: {0}", GC.CollectionCount(2));

                GC.Collect(0);
                Console.WriteLine("\nAfter GC.Collection(0)");
                Console.WriteLine("Collection occurred in 0th generation: {0}", GC.CollectionCount(0));
                Console.WriteLine("Collection occurred in 1st generation: {0}", GC.CollectionCount(1));
                Console.WriteLine("Collection occurred in 2nd generation: {0}", GC.CollectionCount(2));
                Console.WriteLine("ob is in generation: {0}", GC.GetGeneration(ob));
                Console.WriteLine("Now, total memory is: {0}", GC.GetTotalMemory(false));
                
                GC.Collect(1);
                Console.WriteLine("\nAfter GC.Collection(0)");
                Console.WriteLine("Collection occurred in 0th generation: {0}", GC.CollectionCount(0));
                Console.WriteLine("Collection occurred in 1st generation: {0}", GC.CollectionCount(1));
                Console.WriteLine("Collection occurred in 2nd generation: {0}", GC.CollectionCount(2));
                Console.WriteLine("ob is in generation: {0}", GC.GetGeneration(ob));
                Console.WriteLine("Now, total memory is: {0}", GC.GetTotalMemory(false));
                
                GC.Collect(2);
                Console.WriteLine("\nAfter GC.Collection(0)");
                Console.WriteLine("Collection occurred in 0th generation: {0}", GC.CollectionCount(0));
                Console.WriteLine("Collection occurred in 1st generation: {0}", GC.CollectionCount(1));
                Console.WriteLine("Collection occurred in 2nd generation: {0}", GC.CollectionCount(2));
                Console.WriteLine("ob is in generation: {0}", GC.GetGeneration(ob));
                Console.WriteLine("Now, total memory is: {0}", GC.GetTotalMemory(false));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
