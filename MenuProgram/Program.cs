namespace MenuProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1 Add, 2 Update, 3 Exit");
                Console.WriteLine("Enter your choice");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    //success
                    switch (choice)
                    {
                        case 1:
                        case 2:
                            Console.WriteLine("Done");
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break; ;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            
        }
    }
}