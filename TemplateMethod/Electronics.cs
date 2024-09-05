using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Electronics : BaseEngineering
    {
        protected override void SpecialPaper()
        {
            Console.WriteLine("Digital logic and circuit theory");
        }
        protected override bool IsAdditionalPaperNeeded()
        {
            return false;
        }
    }
}
