using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = new();
        private static int numberOfInstances = 0;
        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            numberOfInstances++;
            Console.WriteLine("Number of instance: {0}", numberOfInstances);
        }

        public static Singleton Instance 
        { 
            get 
            {
                Console.WriteLine("We already have an instance now. Use it");
                return instance; 
            } 
        }
    }
}
