//4-13 , Exercise 1
//5-3, add practice on string
namespace DataScrubbing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool toContinue = true;
            while (toContinue)
            {
                Console.WriteLine("Please enter the phone number: ");
                string phone = Console.ReadLine();

                Console.WriteLine("Please enter your choice: 1 Trim, 2 remove , 3 remove and replace");
                string choiceInput = Console.ReadLine();
                string charToRemove;
                if (int.TryParse(choiceInput, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ScrubPhone(ref phone);
                            Console.WriteLine(phone);
                            break;
                        case 2:
                            Console.WriteLine("Please enter the char to remove");
                            charToRemove = Console.ReadLine();
                            ScrubPhone(ref phone, char.Parse(charToRemove));
                            Console.WriteLine(phone);
                            break;
                        case 3:
                            Console.WriteLine("Please enter the char to remove : ");
                            charToRemove = Console.ReadLine();
                            Console.WriteLine("Please enter the char to replace with : ");
                            string charToReplaceWith = Console.ReadLine();
                            ScrubPhone(ref phone, char.Parse(charToRemove), char.Parse(charToReplaceWith));
                            Console.WriteLine(phone);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }

                Console.WriteLine("Do you want to continue? (y/n) :");
                string command = Console.ReadLine();
                toContinue = command == "y";
            }
        }

        public static void ScrubPhone(ref string phone)
        {
            phone = phone.Trim();
        }

        public static void ScrubPhone(ref string? phoneNumber, char charToRemove)
        {
            phoneNumber = phoneNumber.Replace(charToRemove, '\0').Trim();
        }

        public static void ScrubPhone(ref string? phoneNumber, char charToRemove, char charToReplaceWith)
        {
            phoneNumber = phoneNumber.Replace(charToRemove, charToReplaceWith).Trim();
        }
    }
}