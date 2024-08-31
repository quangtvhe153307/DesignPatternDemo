using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class RobotFactory
    {
        public Dictionary<string, IRobot> shapes = new();

        public IRobot GetRobotFromFactory(string type)
        {
            if(shapes.ContainsKey(type)) return shapes[type];

            IRobot robot;
            switch (type)
            {
                case "small":
                    robot = new Robot("small");
                    shapes.Add(type, robot);
                    return robot;
                case "large":
                    robot = new Robot("small");
                    shapes.Add(type, robot);
                    return robot;
                default:
                    throw new ArgumentException();
            }
        }
        public int TotalObjectsCreated()
        {
            return shapes.Count;
        }

    }
}
