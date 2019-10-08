using System;
using System.Collections.Generic;

namespace employeeList
{
    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> EmployeeList = new List<Employee>();

        public Company(string name, string date)
        {
            Name = name;
            CreatedOn = Convert.ToDateTime(date);
        }
        public void ListEmployees()
        {
            foreach (Employee emp in EmployeeList)
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