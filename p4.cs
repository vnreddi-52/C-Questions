using System.Collections.Generic;
using System.Dynamic;

class Employee
{
    public string Name {get; set;}
    public string Department{get; set;}
    public decimal Salary{get; set;}

    public Employee(string name, string department, decimal salary)
{
    Name = name;
    Department = department;
    Salary = salary;
}

    public static void Main(string[] args)
    {
        List<Employee> list=new List<Employee>()
        {
            new Employee("Vaish","IT",90000),
            new Employee("Kashif","IT",89999),
            new Employee("Gaya","HR",78000)
        };

        Dictionary<string, decimal> dict = new Dictionary<string, decimal>();

        foreach(Employee e in list)
        {
            if (dict.ContainsKey(e.Department))
            {
                dict[e.Department]+=e.Salary;
            }
            else
            {
                dict.Add(e.Department, e.Salary);
            }
        }
    }
}


