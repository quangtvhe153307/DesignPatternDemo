using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineVisitorWithComposite
{
    public class Employee : IEmployee
    {
        public string Dept {  get; set; }
        public string Name { get; set; }
        public int YearsOfExperiences { get; set; }

        public Employee(string name, string dept, int yearsOfExperiences)
        {
            Dept = dept;
            Name = name;
            YearsOfExperiences = yearsOfExperiences;
        }

        public void PrintStructure()
        {
            Console.WriteLine("Name: {0}, Department: {1}.", Name, Dept);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployee(this);
        }
    }
}
