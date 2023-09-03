using System.Globalization;

namespace TerminationDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter insurance policy renewal date in (DD-MM-YYYY) : ");
            string dateIput = Console.ReadLine();
            if(DateTime.TryParse(dateIput, out DateTime renewalDate))
            {
                Console.WriteLine($"10 Day Grace Period Date: {renewalDate.AddDays(10)}");
                Console.WriteLine($"Policy cancel date for no payment (1 month from the due date) : {renewalDate.AddMonths(1)}");
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }
            
        }
    }
}