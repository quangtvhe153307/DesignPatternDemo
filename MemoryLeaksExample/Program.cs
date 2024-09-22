namespace MemoryLeaksExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, SimpleEventClass> dic = new Dictionary<int, SimpleEventClass>();

            for (int i = 0; i < 500000; i++)
            {
                using (dic[i] = new SimpleEventClass())
                {
                    //dic[i] = new SimpleEventClass() { Id = i};
                    var ersult = dic[i].SimpleDelegate("Event raised");
                    Console.WriteLine("Current object no.{0}", dic[i].Id + 1);
                    dic[i] = null;
                }

            }
        }
    }
}
