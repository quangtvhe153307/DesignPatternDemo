using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class RobotHands
    {
        public void ResetMilanoHands()
        {
            Console.WriteLine("Reset milano hands");
        }
        
        public void SetMilanoHands()
        {
            Console.WriteLine("Set milano hands");
        }
        
        public void ResetRobonautHands()
        {
            Console.WriteLine("Reset robonaut hands");
        }
        
        public void SetRebonautHands()
        {
            Console.WriteLine("Set Robonaut hands");
        }
    }
}
