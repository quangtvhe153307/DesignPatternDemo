using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineVisitorWithComposite
{
    public class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public int YearsOfExperiences { get; set; }
        public List<IEmployee> controls;

        public CompositeEmployee(string name, string dept, int yearsOfExperiences)
        {
            Name = name;
            Dept = dept;
            YearsOfExperiences = yearsOfExperiences;
            this.controls = new();
        }

        public void PrintStructure()
        {
            Console.WriteLine("Name: {0}, Department {1}.", Name, Dept);
            foreach (var item in controls)
            {
                item.PrintStructure();
            }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompositeEmployee(this);
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
