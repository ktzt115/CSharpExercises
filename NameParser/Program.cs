//5-4 , Exercie 2
namespace NameParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Please enter your name in this format : First Name<space>Middle Name(Optional)<space>Last Name");
                string nameInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(nameInput))
                {
                    var nameSplits = nameInput.Split(' ');
                    Console.WriteLine($"Name: {nameInput}");
                    Console.WriteLine($"First Name: {nameSplits[0]}");
                    Console.WriteLine($"Middle Name: {(nameSplits.Length > 2 ? nameSplits[1] : "<undefined>")}");
                    Console.WriteLine($"Last Name: {nameSplits[nameSplits.Length-1]}");
                }
                else
                {
                    Console.WriteLine("Please enter a name.");
                }
            }
            
        }
    }
}