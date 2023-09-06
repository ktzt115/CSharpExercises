//workbook 2, 4-16 , Exercise 1
namespace EventLookup
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Event>> eventMappings = new Dictionary<string, List<Event>>();
            eventMappings["comedy"] = new List<Event>()
            {
                new Event("Event 1", "Description 1", new DateTime(2023,12,25), 15.00),
                new Event("Event 11", "I am here", new DateTime(2023,12,25), 34.00)
            };
            eventMappings["music"] = new List<Event>()
            {
                 new Event("Event 2", "Description 2", new DateTime(2023,9,15), 20.00)
            };
            eventMappings["festival"] = new List<Event>()
            {
                 new Event("Event 3", "Description 3", new DateTime(2023,10,23), 30)
            };
            eventMappings["other"] = new List<Event>()
            {
                 new Event("Event 4", "Description 4", new DateTime(2023,11,14), 25)
            };

            var categories = eventMappings.Keys.Select(x => x.ToLower());
            while (true)
            {
                Console.WriteLine("Please enter category of event. (Comedy, Music, Festival, Other) : ");
                string input = Console.ReadLine().ToLower();
                if (categories.Contains(input))
                {
                    var events = eventMappings[input];
                    foreach (var eventItem in events)
                    {
                        Console.WriteLine(eventItem);
                    }
                }
            }

        }
    }
}