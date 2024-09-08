using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Mute : IPossibleState
    {
        TV tvContext;

        public Mute(TV context)
        {
            this.tvContext = context;
            Console.WriteLine("TV is Mute now");
        }

        public void PressMuteButton(TV context)
        {
            Console.WriteLine("You pressed Mute button. TV is already on Mute state");
        }

        public void PressOffButton(TV context)
        {
            Console.WriteLine("You pressed Off button. Going from Mute to Off state");
            tvContext.State = new Off(context);
        }

        public void PressOnButton(TV context)
        {
            Console.WriteLine("You pressed On button. Going from Mute to On state");
            tvContext.State = new On(context);
        }
    }
}
