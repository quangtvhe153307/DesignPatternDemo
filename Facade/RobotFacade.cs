using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class RobotFacade
    {
        private RobotBody body;
        private RobotHands hands;
        private RobotColor color;

        public RobotFacade()
        {
            this.body = new();
            this.hands = new();
            this.color = new();
        }

        public void ConstructMilanoRobot()
        {
            Console.WriteLine("Milano robot is constructing");
            color.SetDefaultColor();
            hands.SetMilanoHands();
            body.CreateHands();
            body.CreateRemainingPart();
        }
        
        public void ConstructRobonautRobot()
        {
            color.SetGreen();
            hands.SetRebonautHands();
            body.CreateHands();
            body.CreateRemainingPart();
            Console.WriteLine("Robonaut robot is constructing");
            Console.WriteLine();
        }

        public void DestroyMilanoRobot()
        {
            body.DestroyRemainingParts();
            body.DestroyHands();
            hands.ResetMilanoHands();
        }
        
        public void DestroyRobonautRobot()
        {
            body.DestroyRemainingParts();
            body.DestroyHands();
            hands.ResetRobonautHands();
        }
    }
}
