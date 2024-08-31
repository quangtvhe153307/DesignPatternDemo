using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class RobotBody
    {
        public void CreateHands()
        {
            Console.WriteLine("Create Hands");
        }
        
        public void CreateRemainingPart()
        {
            Console.WriteLine("Create remaining part");
        }
        
        public void DestroyHands()
        {
            Console.WriteLine("Destroy Hands");
        }
        
        public void DestroyRemainingParts()
        {
            Console.WriteLine("Destroy remaining part");
        }
    }
}
