// 3-9 , exercise 2

int[] years = new int[] { 1900, 1950, 1999, 2000, 2001, 2012,2023,2024};

for (int i = 0; i < years.Length; i++)
{
    int currentYear = years[i];

    //very long 
    //if(currentYear % 4 == 0)
    //{
    //    if(currentYear % 100 == 0)
    //    {
    //        if (currentYear % 400 == 0)
    //        {
    //            Console.WriteLine($"{currentYear} is a leap year.");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"{currentYear} is not a leap year.");
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{currentYear} is a leap year.");
    //    }
    //}
    //else
    //{
    //    Console.WriteLine($"{currentYear} is not a leap year.");
    //}

    //alternative using Ternary expression, however readibility is a trade-off
    bool isLeapYear = currentYear %4 ==0 ? currentYear %100 ==0 ? currentYear % 400 == 0 ? true: false : true  : false;
    Console.WriteLine($"{currentYear} is{(isLeapYear ? "" : " not ")} a leap year.");

    Console.WriteLine("--------------------------");

}

