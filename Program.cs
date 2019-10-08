using System;
using System.Collections.Generic;

namespace employeeList
{
    class Program
    {
        static void Main(string[] args)
        {
        // Create an instance of a company. Name it whatever you like.
        var Google = new Company("Google INC", "1/1/2000");

        // Create three employees
        Employee test= new Employee(){
           FirstName = "Bobby",
           LastName = "Bob",
           Title = "Janitor",
           StartDate = Convert.ToDateTime("10/20/2006")
        };
        Google.AddEmployee(test);
        var me = new Employee("Michelle", "Jimenez", "Developer", "10/8/2019");
        var Billy = new Employee("Billy", "Bob", "Manger", "1/23/2016");
        var Joe = new Employee("Joe", "Shmo", "supervisor", "2/5/2004");

        // Assign the employees to the company
        Google.AddEmployee(me);
        Google.AddEmployee(Billy);
        Google.AddEmployee(Joe);

        Google.ListEmployees();
        }
    }
}