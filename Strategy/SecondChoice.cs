﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SecondChoice : IChoice
    {
        public void MyChoice()
        {
            Console.WriteLine("My choice is traveling to Vietnam");
        }
    }
}
