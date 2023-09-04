//Workbook 2, 4-24, Exercise 1
namespace LINQPlay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Stock> stockList = new List<Stock>() { 
                new Stock("AAPL", "Apple", 189.11, 15),
                new Stock("AMZ", "Amazon", 201.25, 10),
                new Stock("TSLA", "Tesla", 221.54, 5),
                new Stock("MST", "Microsoft", 150.21, 50),
                new Stock("GTP", "GTP Ltd", 1, 1000),
                new Stock("GGL", "Google", 20.11, 100),
                new Stock("PFZ", "Pfizer", 45.00, 8),
                new Stock("PRX", "Pyrex", 0.54, 3000),
                new Stock("KKK", "Triple K", 0.54, 14),
            };

            var stocksQuery = from stock in stockList
                              where stock.SharePrice < 20
                              select stock;

            Console.WriteLine("Stock with less than 20 share price");
            foreach (Stock stock in stocksQuery)
            {
                Console.WriteLine(stock);
            }


            stocksQuery = stockList
                .Where(stock => stock.SharePrice >= 20 && stock.SharePrice <= 75);
            Console.WriteLine("\n\nStock between 20 and 75 share price");
            foreach (Stock stock in stocksQuery)
            {
                Console.WriteLine(stock);
            }

            var cheapestPrice = stockList.Select(stock => stock.SharePrice).Min();
            stocksQuery = stockList.Where(stock => stock.SharePrice == cheapestPrice);

            Console.WriteLine("\n\nCheapest stocks I own");
            foreach (Stock stock in stocksQuery)
            {
                Console.WriteLine(stock);
            }

            var stockInvestments = GetStockInvestments(stockList);
            Console.WriteLine("\n\nStock Investments");
            foreach (var stockInvestment in stockInvestments)
            {
                Console.WriteLine(stockInvestment);
            }
        }

        public static List<StockInvestment> GetStockInvestments(List<Stock> stocks)
        {
            return stocks.Select(x => new StockInvestment
            {
                TickerSymbol = x.TickerSymbol,
                StockName = x.StockName,
                TotalValue = x.UnitsOwned * x.SharePrice
            }).ToList();
        }
    }
}