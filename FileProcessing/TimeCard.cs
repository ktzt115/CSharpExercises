namespace FileProcessing
{
    public class TimeCard
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public double PayRate { get; set; }

        public static TimeCard CreateTimeCard(string inputToParse)
        {
            var splitted = inputToParse.Split('|');
            if(splitted.Any() && splitted.Length >= 3)
            {
                return new TimeCard
                {
                    Name = splitted[0],
                    HoursWorked = int.Parse(splitted[1]),
                    PayRate = double.Parse(splitted[2])
                };
            }
            else
            {
                throw new InvalidCastException("The data format provided is not valid one. Please correct the data.");
            }
            
        }

        public double GetGrossPay()
        {
            return HoursWorked > 40 ? HoursWorked * PayRate * 1.5 : HoursWorked * PayRate;
        }
    }
}
