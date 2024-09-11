
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class HundredExpression : InputExpression
    {
        public override void Interpreter(Context context)
        {
            if (context.CanProceed)
            {
                int hundred = context.GetInput / 100;
                
                switch (hundred)
                {
                    case 1:
                        context.SetOutput += "One Hundred";
                        break;
                    case 2:
                        context.SetOutput += "Two Hundred";
                        break;
                    case 3:
                        context.SetOutput += "Three Hundred";
                        break;
                    case 4:
                        context.SetOutput += "Four Hundred";
                        break;
                    case 5:
                        context.SetOutput += "Five Hundred";
                        break;
                    case 6:
                        context.SetOutput += "Six Hundred";
                        break;
                    case 7:
                        context.SetOutput += "Seven Hundred";
                        break;
                    case 8:
                        context.SetOutput += "Eight Hundred";
                        break;
                    case 9:
                        context.SetOutput += "Nine Hundred";
                        break;
                    default:
                        context.SetOutput += string.Empty;
                        break;
                }
            }
        }
    }
}
