//5-18 , Exercise 1

namespace Searcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Sausage Breakfast Taco",
                "Potato and Egg Breakfast Taco",
                "Sausage and Egg Biscuit",
                "Bacon and Egg Biscuit",
                "Pancakes"};
            decimal[] prices = { 3.99M, 3.29M, 3.70M, 3.99M, 4.79M };

            while(true)
            {
                Console.WriteLine("Please enter the item number you want to order");
                string userInput = Console.ReadLine();
                decimal? priceOfItem = GetPrice(items, prices, userInput);

                Console.WriteLine($"{(priceOfItem.HasValue? $"Price for {userInput} is {priceOfItem.Value:C}": "The food item is not on menu.") }");

                Console.WriteLine("Do you want to order another one? (y/n)");
                userInput = Console.ReadLine();
                if(userInput.ToLower() != "y")
                {
                    Environment.Exit(0 );
                }
            }
        }

        private static decimal? GetPrice(string[] items, decimal[] prices, string? userInput)
        {
            for(int i = 0;i < items.Length; i++)
            {
                if (items[i].ToLower().Equals(userInput.ToLower()))
                {
                    return prices[i];
                }
            }

            return null;
        }
    }
}