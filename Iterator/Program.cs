namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ISubject scienceSubject = new ScienceSubject();
            ISubject artSubject = new ArtSubject();

            IIterator scienceIterator = scienceSubject.CreateIterator();
            IIterator artIterator = artSubject.CreateIterator();

            Console.WriteLine("Science");
            Print(scienceIterator);

            Console.WriteLine("Art");
            Print(artIterator);

        }
        public static void Print(IIterator iterator)
        {
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
