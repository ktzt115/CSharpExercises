namespace AssetManager
{
    abstract class Asset
    {
        public int AssetId { get; set; }

        public string Description { get; set; }
        public DateTime DateAcquired { get; set; }

        public double OriginalCost { get; set; }

        public Asset(int assetId, string description, DateTime dateAcquired, double originalCost)
        {
            AssetId = assetId;
            Description = description;
            DateAcquired = dateAcquired;
            OriginalCost = originalCost;
        }
        
        public virtual double GetValue()
        {
            return OriginalCost;
        }
    }
}
