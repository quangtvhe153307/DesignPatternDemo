﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public override void MakeHouse()
        {
            Console.WriteLine("House is created");
        }
    }
}
