using System;

namespace employeeList
{
    class Program
    {
        static void Main(string[] args)
        {
        // Create an instance of a company. Name it whatever you like.
        var Veridian = new Company("Veridian Dynamics", "1/2/2003");

        // Create three employees
        var Ted = new Employee("Ted", "Crisp", "Senior VP of Research and Development", "1/2/2012");
        var Veronica = new Employee("Veronica", "Palmer", "Supervisor", "6/5/2010");
        var Linda = new Employee("Linda", "Zwordling", "Product Tester", "4/4/2009");

        // Assign the employees to the company
        Veridian.AddEmployee(Ted);
        Veridian.AddEmployee(Veronica);
        Veridian.AddEmployee(Linda);

        Veridian.ListEmployees();
        }
    }
}

