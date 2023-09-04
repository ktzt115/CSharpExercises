//workbook 2, 4-18, exercise 1

namespace PeopleManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Person p1 = new Person("Thuzar", 31, "111 Sengkang Street", "Punggol", "Singapore", 854121);
            Person p2 = new Person("Amanda", 12, "123 Buangkok Lane", "Ang Mo Kio", "Singapore", 354644);
            Person p3 = new Person("Richard", 16, "565 Holland Village Lnk", "Johor", "Malaysia", 845214);
            Person p4 = new Person("Joanna", 40, "655 Woolands Street 22", "Bahan", "Myanmar", 254115);
            Worker w1 = new Worker("Khin", 32, "154 Kallang Street", "Kallang", "Singapore", 354655, "Manager", 8000);
            Worker w2 = new Worker("Angela", 40, "254 Yishun Street", "Yishun", "Singapore", 451143, "Sales Executive", 7540);
            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);
            people.Add(w1);
            people.Add(w2);

            p2.HaveABirthday();

            people.Sort(new AscendingAgeSorter());

            foreach (Person person in people)
            {
                person.Display();
            }

            Console.WriteLine();
            Console.WriteLine();
            people.Sort(new DescendingAgeSorter());

            foreach (Person person in people)
            {
                person.Display();
            }

            Console.WriteLine();
            Console.WriteLine();

            people.Sort(new AscendingZipcodeSorter());

            foreach (Person person in people)
            {
                person.Display();
            }
            Console.WriteLine();
            Console.WriteLine();

            people.Sort(new DescendingZipcodeSorter());

            foreach (Person person in people)
            {
                person.Display();
            }
            Console.WriteLine();
            Console.WriteLine();

            people.Sort(new AscendingStateAndCity());

            foreach (Person person in people)
            {
                person.Display();
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}