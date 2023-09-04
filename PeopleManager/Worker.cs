using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager
{
    internal class Worker : Person
    {
        public string JobTitle { get; set; }
        public double Salary { get; set; }
        public Worker(string name, int age, string address, string city, string state,
            int zipcode, string jobTitle, double salary) : base(name, age, address, city, state, zipcode)
        {
            JobTitle = jobTitle;
            Salary = salary;
        }

        public override void Display()
        {
            Console.WriteLine($"Worker - Name :{Name} , Title : {JobTitle} , Salary : {Salary:C}");
        }
    }
}
