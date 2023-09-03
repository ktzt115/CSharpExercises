int currentHour = DateTime.Now.Hour;
if(currentHour >= 0  && currentHour < 5)
{
    Console.WriteLine("Welcome to the late shift!");
}else if (currentHour >= 5 && currentHour < 10)
{
    Console.WriteLine("Good Morning!");
}
else if (currentHour >=10 && currentHour < 18)
{
    Console.WriteLine("Good Day!");
}
else
{
    Console.WriteLine("Good Evening!");

}