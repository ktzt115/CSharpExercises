// workbook 2, 2-16, exercise 1

namespace AssetManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asset[] assets = new Asset[6];

            assets[0] = new Stock(1, "Microsoft stock", new DateTime(2022, 10, 3), 120, "MSFT", 190, 4);
            assets[1] = new Stock(2, "Amazon stock", new DateTime(2022, 12, 1), 200, "AMZN", 250, 10);
            assets[2] = new Stock(3, "Google stock", new DateTime(2023, 3, 3), 100, "GOOG", 150, 20);
            assets[3] = new Car(4, "Toyota", new DateTime(2019, 3, 3), 100000, 2018, 10000);
            assets[4] = new Car(5, "Honda", new DateTime(2010, 3, 3), 100000, 2009, 15000);
            assets[5] = new Car(6, "Suzuki", new DateTime(2015, 3, 3), 100000, 2010, 30000);

            Console.WriteLine("Description\t\tDate Acquired\tValue");
            foreach (var asset in assets) {
                Console.WriteLine($"{asset.Description}" +
                    $"\t{asset.DateAcquired.ToShortDateString()}" +
                    $"\t{asset.GetValue()}");
            }

            Console.WriteLine(" ---------------- Car Info ---------------------");
            foreach(var item in assets)
            {
                if(item is Car car)
                {
                    Console.WriteLine(car);
                }
            }

            Console.WriteLine(" ---------------- Stock Info ---------------------");
            foreach (var item in assets)
            {
                if (item is Stock stock)
                {
                    Console.WriteLine(stock);
                }
            }

        }

    }
}