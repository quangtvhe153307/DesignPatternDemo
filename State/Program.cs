namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //initially TV is off
            TV tv = new TV();

            Console.WriteLine("User is pressing buttons in the following sequence:");
            Console.WriteLine("Off -> Mute -> On -> On -> Mute -> Mute -> Off");

            tv.PressOffButton();
            tv.PressMuteButton();
            tv.PressOnButton();
            tv.PressOnButton();
            tv.PressMuteButton();
            tv.PressMuteButton();
            tv.PressOffButton();
        }
    }
}
