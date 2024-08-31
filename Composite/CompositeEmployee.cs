using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CompositeEmployee : IEmployee
    {
        private List<IEmployee> controls;
        private string dept;
        private string name;

        public CompositeEmployee(string dept, string name)
        {
            this.controls = new();
            this.dept = dept;
            this.name = name;
        }

        public void PrintStructure()
        {
            Console.WriteLine("Department: {0}, Name: {1}", dept, name);
            foreach (var control in controls)
            {
                control.PrintStructure();
            }
        }
        public void Add(IEmployee employee) 
        {
            controls.Add(employee);
        }

        public void Remove(IEmployee employee)
        {
            controls.Remove(employee);
        }
    }
}
