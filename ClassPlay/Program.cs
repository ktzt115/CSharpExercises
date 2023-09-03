namespace ClassPlay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee()
            {
                FirstName = "Brad",
                LastName = "Pitt",
                EmployeeId = 007,
                YearJoined = 2022,
                JobTitle = "Actor",
                Department = "Hollywood",
                Salary = 2030
            };
            employee1.Display();
            Console.WriteLine("----------------------");


            Employee employee2 = new Employee("Khin",
                            "Thuzar",
                            1,
                            2023,
                            "Developer",
                            "Good Department",
                            4500
                        );
            employee2.Display();

            Console.WriteLine("----------------------");
            Employee employee3 = new Employee("John", "Doe", 15);
            employee3.Display();

            Console.WriteLine("---  Promoting John Doe ------");
            employee3.Promote("Sales Executie", 1800.00);
            employee3.Display();

        }

        private static void DisplayEmployee(Employee employee)
        {
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
            Console.WriteLine(employee.EmployeeId);
            Console.WriteLine(employee.YearJoined);
            Console.WriteLine(employee.JobTitle);
            Console.WriteLine(employee.Department);
            Console.WriteLine(employee.Salary);
        }
    }
}