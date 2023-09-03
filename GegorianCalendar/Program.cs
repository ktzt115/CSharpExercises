// See https://aka.ms/new-console-template for more information

int[] years = new int[] { 1900, 1950, 1999, 2000, 2001, 2012};

for (int i = 0; i < years.Length; i++)
{
    int currentYear = years[i];
    bool isLeapYear = currentYear % 4 == 0;
    Console.WriteLine($"{currentYear} is {(isLeapYear ? "" : "not")} a leap year");

}

