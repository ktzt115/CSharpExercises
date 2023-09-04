namespace LINQGames
{
    class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public Supplier(int supplierId, string name,
        string url)
        {
            SupplierId = supplierId;
            Name = name;
            URL = url;
        }
        public override string ToString()
        {
            return $"{SupplierId} - {Name} - Url: {URL}";
        }
    }
}
