using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    internal class Car : Asset
    {
        public Car(int assetId, string description, DateTime dateAcquired, double originalCost, int modelYear, double odometerReading)

            : base(assetId, description, dateAcquired, originalCost)
        {
            ModelYear = modelYear;
            OdometerReading = odometerReading;
        }


        public int ModelYear { get; set; }

        public double OdometerReading { get; set; }

        public override double GetValue()
        {
            double depreciationCost;
            if ((DateTime.Today.Year - ModelYear) < 7)
            {
                depreciationCost = OdometerReading / 5000 * 0.2;
                depreciationCost = depreciationCost > (0.9 * OriginalCost) ? OriginalCost * 0.9 : depreciationCost;

            }
            else
            {
                depreciationCost = OdometerReading < 10000 ? OriginalCost - OriginalCost * 0.7 : OriginalCost - OriginalCost * 0.9;

            }
            return depreciationCost;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
