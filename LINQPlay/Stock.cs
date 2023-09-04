using NPOI.SS.Formula.Functions;

namespace LINQPlay
{
    internal class Stock
    {
        public string TickerSymbol { get; set; }

        public string StockName { get; set;}
        public double SharePrice { get; set;}
        public int UnitsOwned { get; set; }

        public Stock(string tickerSymbol, string stockName, double sharePrice, int unitsOwned)
        {
            TickerSymbol = tickerSymbol;
            StockName = stockName;
            SharePrice = sharePrice;
            UnitsOwned = unitsOwned;
        }

        public override string? ToString()
        {
            return $"{TickerSymbol}\t-{StockName}\t-{SharePrice:C}\t-{UnitsOwned}\t";
        }
    }
}
