using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineVisitorWithComposite
{
    public class Visitor : IVisitor
    {
        public void VisitCompositeEmployee(CompositeEmployee employee)
        {
            bool eligibleForPromotion = employee.YearsOfExperiences > 15;
            if(eligibleForPromotion)
            Console.WriteLine("{0} from {1} is eligible for promotion", employee.Name, employee.Dept);
        }

        public void VisitEmployee(Employee employee)
        {
            bool eligibleForPromotion = employee.YearsOfExperiences > 12;
            if(eligibleForPromotion)
            Console.WriteLine("{0} from {1} is eligible for promotion", employee.Name, employee.Dept);
        }
    }
}
