using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TV
    {
        private IPossibleState state;
        public IPossibleState State { get { return state; } set { this.state = value; } }

        public TV() {
            state = new Off(this);
        } 
        public void PressOffButton()
        {
            state.PressOffButton(this);
        }
        public void PressOnButton()
        {
            state.PressOnButton(this);
        }
        public void PressMuteButton()
        {
            state.PressMuteButton(this);
        }
    }
}
