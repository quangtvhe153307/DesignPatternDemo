using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class On : IPossibleState
    {
        TV tvContext;
        public On(TV context)
        {
            this.tvContext = context;
            Console.WriteLine("TV is On now");
        }

        public void PressMuteButton(TV context)
        {
            Console.WriteLine("You pressed Mute button. Going from On to Mute state");
            tvContext.State = new Mute(context);
        }

        public void PressOffButton(TV context)
        {
            Console.WriteLine("You pressed Off button. Going from On to Off state");
            tvContext.State = new Off(context);
        }

        public void PressOnButton(TV context)
        {
            Console.WriteLine("You pressed On button. TV is already in On state");
        }
    }
}
