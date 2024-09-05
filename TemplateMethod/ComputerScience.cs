using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ComputerScience : BaseEngineering
    {
        protected override void SpecialPaper()
        {
            Console.WriteLine("OOP");
        }
    }
}
