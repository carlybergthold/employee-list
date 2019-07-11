using System;
using System.Collections.Generic;

namespace employeeList
{
    public class Company
    {
        public string Name { get; }
        public DateTime DateFounded { get; }
        public List<Employee> EmployeeList = new List<Employee>();
        public Company()
        {

        }
        public Company(string name, string date)
        {
            Name = name;
            DateFounded = Convert.ToDateTime(date);
        }
        public void ListEmployees()
        {
            foreach (var emp in EmployeeList)
            {
                Console.WriteLine($"{emp.FirstName} has worked at {Name} as {emp.Title} since {emp.StartDate}");
            }
        }
        public void AddEmployee(Employee emp)
        {
            EmployeeList.Add(emp);
        }
    }
}