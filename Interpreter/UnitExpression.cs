using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class UnitExpression : InputExpression
    {
        public override void Interpreter(Context context)
        {
            if (context.CanProceed)
            {
                int untis = context.GetInput % 10;

                switch (untis)
                {
                    case 1:
                        context.SetOutput += " One";
                        break;
                    case 2:
                        context.SetOutput += " Two";
                        break;
                    case 3:
                        context.SetOutput += " Three";
                        break;
                    case 4:
                        context.SetOutput += " Four";
                        break;
                    case 5:
                        context.SetOutput += " Five";
                        break;
                    case 6:
                        context.SetOutput += " Six";
                        break;
                    case 7:
                        context.SetOutput += " Seven";
                        break;
                    case 8:
                        context.SetOutput += " Eight";
                        break;
                    case 9:
                        context.SetOutput += " Nine";
                        break;
                    default:
                        context.SetOutput += string.Empty;
                        break;
                }
            }
        }
    }
}
