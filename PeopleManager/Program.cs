//workbook 2, 4-18

namespace PeopleManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            
            Person p1 = new Person("Thuzar", 31, "111 Sengkang Street", "Singapore", "Singapore", 854121);
            Person p2 = new Person("Amanda", 12, "123 Buangkok Lane", "Singapore", "Singapore", 354644);
            Person p3 = new Person("Richard", 16, "565 Holland Village Lnk", "Singapore", "Singapore", 845214);
            Person p4 = new Person("Joanna", 40, "655 Woolands Street 22", "Singapore", "Singapore", 254115);

            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);

            p2.HaveABirthday();

            people.Sort(new AscendingAgeSorter());

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            Console.WriteLine();
            people.Sort(new DescendingAgeSorter());

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            Console.WriteLine();

            people.Sort(new AscendingZipcodeSorter());

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            Console.WriteLine();

            people.Sort(new DescendingZipcodeSorter());

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            Console.WriteLine();

            people.Sort();

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}