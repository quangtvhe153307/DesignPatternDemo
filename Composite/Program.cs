namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompositeEmployee level1Employee = new CompositeEmployee( "dep1" ,"harrison");
            CompositeEmployee level2Employee1 = new CompositeEmployee( "dep2" ,"harrison");
            CompositeEmployee level2Employee2= new CompositeEmployee( "dep2" ,"harrison");
            Employee level3Employee1 = new Employee("dep3", "harrison1");
            Employee level3Employee2= new Employee("dep3", "harrison2");
            Employee level3Employee3 = new Employee("dep3", "harrison3");
            Employee level3Employee4 = new Employee("dep3", "harrison4");
            Employee level3Employee5 = new Employee("dep3", "harrison5");
            Employee level3Employee6 = new Employee("dep3", "harrison6");

            level1Employee.Add(level2Employee1);
            level1Employee.Add(level2Employee2);
            level2Employee1.Add(level3Employee1);
            level2Employee1.Add(level3Employee2);
            level2Employee2.Add(level3Employee3);
            level2Employee2.Add(level3Employee4);
            level2Employee2.Add(level3Employee5);
            level2Employee2.Add(level3Employee6);

            level1Employee.PrintStructure();
        }
    }
}
