namespace EventLookup
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public double TicketPrice { get; set; }

        public Event(string name, string description, DateTime eventDate, double ticketPrice)
        {
            Name = name;
            Description = description;
            EventDate = eventDate;
            TicketPrice = ticketPrice;
        }

        public override string ToString()
        {
            return $"Date {EventDate: dd/MM/yyyy} {Description} {TicketPrice:C}";
        }
    }
}