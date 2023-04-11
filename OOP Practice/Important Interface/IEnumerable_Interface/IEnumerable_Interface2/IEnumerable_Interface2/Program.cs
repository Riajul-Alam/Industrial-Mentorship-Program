using IEnumerable_Interface2;



public class TestEmployee
{
    public static void Main(string[] args)
    {
        //List<Employee> Employees = new List<Employee>();
        Organization Employees = new Organization();
        Employees.Add(new Employee(101, "Riaj", "Developer", 100002.55));
        Employees.Add(new Employee(102, "Raju", "Developer", 500002.55));
        Employees.Add(new Employee(103, "Rakib", "Developer",800002.55));
        Employees.Add(new Employee(104, "Rahim", "Manager", 1000002.55));


        // --> gives this error when i can't inherite IEnumerable interface <--

        //foreach statement cannot operate on variables of type 'Organization'
        //because 'Organization' does not contain a public instance or extension definition 
        //for 'GetEnumerator'

        foreach (Employee emp in Employees)
        {
            Console.WriteLine(emp.Id+" "+emp.Name+" "+emp.Job+" "+emp.Salary);
        }
    }
}