using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Off : IPossibleState
    {
        TV tvContext;
        public Off(TV context) { 
            this.tvContext = context;
            Console.WriteLine("TV is off now");
        }
        public void PressMuteButton(TV context)
        {
            Console.WriteLine("You pressed Mute button. TV is already in Off state, so Mute operation will not work");
        }

        public void PressOffButton(TV context)
        {
            Console.WriteLine("You pressed Off button. TV is already in Off state");
        }

        public void PressOnButton(TV context)
        {
            Console.WriteLine("You are pressing On button. Going from Off to On state");
            tvContext.State = new On(context);
        }
    }
}
