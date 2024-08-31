namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RobotFacade facade = new();
            facade.ConstructRobonautRobot();
            facade.DestroyRobonautRobot();
            facade.ConstructMilanoRobot();
            facade.DestroyMilanoRobot();
        }
    }
}
