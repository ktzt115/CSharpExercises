using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlay
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int EmployeeId { get; set; }
        public int YearJoined { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public Employee(string firstName, string lastName, int employeeId, int yearJoined, string jobTitle, string department, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
            YearJoined = yearJoined;
            JobTitle = jobTitle;
            Department = department;
            Salary = salary;
        }

        public Employee(string firstName, string lastName, int employeeId) 
            : this(firstName, lastName, employeeId, DateTime.Now.Year, "New Hire", "TBD", 15.00)
        {

        }

        public Employee()
        {
        }



        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        internal void Display()
        {
            Console.WriteLine($"{EmployeeId} : {FirstName} {LastName}");
            Console.WriteLine($"{JobTitle} , {Department}");
            Console.WriteLine($"Joined on {YearJoined}");
            Console.WriteLine($"Current Salary : {Salary:0.00}");
        }

        public void Promote(string newJobTitle, double newPay)
        {
            JobTitle = newJobTitle;
            Salary = newPay;
        }
    }
}
