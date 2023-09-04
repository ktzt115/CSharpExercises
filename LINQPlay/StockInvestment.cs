using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPlay
{
    internal class StockInvestment
    {
        public string TickerSymbol { get; set; }

        public string StockName { get; set; }
        public double TotalValue { get; set;}

        public override string? ToString()
        {
            return $"{TickerSymbol}\t-\t{StockName}\t\t-\t{TotalValue:C}";
        }
    }
}
