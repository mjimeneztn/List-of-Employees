
using System;

namespace employeeList
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public Employee()
        {

        }
        public Employee(string first, string last, string title, string date)
        {
            FirstName = first;
            LastName = last;
            Title = title;
            StartDate = Convert.ToDateTime(date);
        }
    }
}