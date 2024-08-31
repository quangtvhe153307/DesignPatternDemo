using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Robot : IRobot
    {
        private string colorOfRobot;
        private string robotType;

        public Robot(string type)
        {
            this.robotType = type;
        }

        public override void Print()
        {
            Console.WriteLine(string.Format("{0} robot with {1} color.", this.robotType, this.colorOfRobot));
        }

        public override void SetColor(string color)
        {
            this.colorOfRobot = color;
        }
    }
}
