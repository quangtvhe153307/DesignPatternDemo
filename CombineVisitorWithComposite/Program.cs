namespace CombineVisitorWithComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CompositeEmployee principal = new CompositeEmployee("Principal", "abc", 20);

            CompositeEmployee headOfDept1 = new CompositeEmployee("Head1", "dep1", 14);
            CompositeEmployee headOfDept2 = new CompositeEmployee("Head2", "dep2", 16);
            
            IEmployee jrTeacher1 = new Employee("jr1", "dep1", 10);
            IEmployee jrTeacher2 = new Employee("jr2", "dep2", 11);
            IEmployee jrTeacher3 = new Employee("jr3", "dep2", 12);
            IEmployee jrTeacher4 = new Employee("jr4", "dep2", 13);

            principal.Add(headOfDept1);
            principal.Add(headOfDept2);

            headOfDept1.Add(jrTeacher1);

            headOfDept2.Add(jrTeacher2);
            headOfDept2.Add(jrTeacher3);
            headOfDept2.Add(jrTeacher4);


            principal.PrintStructure();

            IVisitor visitor = new Visitor();

            foreach (IEmployee e in principal.controls)
            {
                e.Accept(visitor);
            }

            foreach (var item in headOfDept1.controls)
            {
                item.Accept(visitor);
            }
            
            foreach (var item in headOfDept2.controls)
            {
                item.Accept(visitor);
            }
        }
    }
}
