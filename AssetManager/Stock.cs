using Newtonsoft.Json;

namespace AssetManager
{
    internal class Stock : Asset
    {
        public Stock(int assetId, string description, DateTime dateAcquired, double originalCost, string stockTicker, double currentSharePrice, int numberOfShares)
            : base(assetId, description, dateAcquired, originalCost)
        {
            StockTicker = stockTicker;
            CurrentSharePrice = currentSharePrice;
            NumberOfShares = numberOfShares;
        }

        public string StockTicker { get; set; }
        public double CurrentSharePrice { get; set; }
        public int NumberOfShares { get; set; }

        public override double GetValue()
        {
            return CurrentSharePrice * NumberOfShares;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
