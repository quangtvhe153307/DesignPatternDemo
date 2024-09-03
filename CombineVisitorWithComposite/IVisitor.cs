using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineVisitorWithComposite
{
    public interface IVisitor
    {
        void VisitCompositeEmployee(CompositeEmployee employee);
        void VisitEmployee(Employee employee);
    }
}
