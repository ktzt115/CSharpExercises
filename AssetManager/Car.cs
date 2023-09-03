using Newtonsoft.Json;

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
            double depreciatedCost;
            if ((DateTime.Today.Year - ModelYear) < 7)
            {
                depreciatedCost = OriginalCost * ( OdometerReading / 5000 * 0.02);
                depreciatedCost = depreciatedCost > (0.9 * OriginalCost) ? OriginalCost * 0.9 : depreciatedCost;
                depreciatedCost = OriginalCost - depreciatedCost;
            }
            else
            {
                depreciatedCost = OdometerReading < 10000 ? OriginalCost - OriginalCost * 0.7 : OriginalCost - OriginalCost * 0.9;

            }
            return depreciatedCost;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
