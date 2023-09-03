namespace DataScrubbing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phone = "817-555-1212   ";
            bool toContinue = true;
            while (toContinue)
            {


                Console.WriteLine("Please enter the phone number: ");
                phone = Console.ReadLine();

                Console.WriteLine("Please enter your choice: 1 Trim, 2 remove , 3 remove and replace");
                string scrubbedPhone = "";
                string choiceInput = Console.ReadLine();
                if (int.TryParse(choiceInput, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            scrubbedPhone = ScrubPhone(phone);
                            Console.WriteLine(scrubbedPhone);
                            break;
                        case 2:
                            break;
                        case 3:
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

        public static string ScrubPhone(string? phone)
        {
            return phone.Trim();
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