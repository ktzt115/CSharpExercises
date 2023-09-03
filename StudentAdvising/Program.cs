//4-13 , exercise 2
namespace StudentAdvising
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string majorCode;
            string classification;
            while(true)
            {
                GatherInfo(out name, out majorCode, out classification);
                string advisingLocationResult = GetAdvisingLocation(majorCode, classification);
                Console.WriteLine($"\n{advisingLocationResult}\n\nDo you want to enter another? ");
                string input = Console.ReadLine();
                if(! input.ToLower().Equals("y"))
                {
                    break;
                }
            }

        }

        private static string GetAdvisingLocation(string majorCode, string classification)
        {
            string nameOfMajor = string.Empty;
            string departmentOffice = string.Empty;
            string majorCodeInput = majorCode.ToUpper();
            var classificationInput = classification.ToLower();
            switch (majorCodeInput)
            {
                case "BIOL":
                    nameOfMajor = "Biology";
                    departmentOffice = classificationInput == "freshmen" || classificationInput == "sophomore" ? "Science Bldg, Room 310" : "Science Bldg, Room 311";
                    break;
                case "CSCI":
                    nameOfMajor = "Computer Science";
                    departmentOffice = "Sheppard Hall, Room 314";
                    break;
                case "ENG":
                    nameOfMajor = "English";
                    departmentOffice = classificationInput == "freshmen" ? "Kerr Hall, Room 201" : "Kerr Hall, Room 312";
                    break;
                case "HIST":
                    nameOfMajor = "History";
                    departmentOffice = "Kerr Hall, Room 114";
                    break;
                case "MKT":
                    nameOfMajor = "Marketing";
                    departmentOffice = classificationInput == "Senior" ? "Westly Hall, Room 313" : "Westly Hall, Room 310";
                    break;
                default:
                    break;

            }
            return $"Advising for {nameOfMajor} {classification} majors : {departmentOffice}";
        }

        static void GatherInfo( out string name,
         out string majorCode, out string classification)
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Major Code: ");
            majorCode = Console.ReadLine();
            Console.Write("Enter Classification: ");
            classification = Console.ReadLine();
        }

    }
}