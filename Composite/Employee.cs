using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Employee : IEmployee
    {
        private string dept;
        private string name;

        public Employee(string dept, string name)
        {
            this.dept = dept;
            this.name = name;
        }

        public void PrintStructure()
        {
            Console.WriteLine("Department: {0}, Name: {1}", dept, name);
        }
    }
}
