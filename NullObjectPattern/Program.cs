namespace NullObjectPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string input = string.Empty;
            int totalObjects = 0;

            while (input != "exit")
            {
                Console.WriteLine("Enter your choice (type 'a' for bus, 'b' for train, 'exit' to quit).");

                input = Console.ReadLine();
                IVehicle vehicle = null;

                switch (input)
                {
                    case "a":
                        vehicle = new Bus();
                        break;
                    case "b":
                        vehicle = new Train();
                        break;
                    case "exit":
                        Console.WriteLine("Trying to close the application");
                        vehicle = NullVehicle.Instance;
                        break;
                    default:
                        vehicle = NullVehicle.Instance;
                        if(input == "exit")
                        {
                            Console.WriteLine("Closing the applcation. Press Enter at end.");
                        }
                        break;
                }
                totalObjects = Bus.busCount + Train.trainCount + NullVehicle.nullVehicleCount;
                vehicle.Travel();

                Console.WriteLine("Total objects created in the system = {0}", totalObjects);
            }
        }
    }
}
