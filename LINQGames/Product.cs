namespace LINQGames
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int QuantityOnHand { get; set; }
        public int SupplierId { get; set; }
        public Product(int productId, string productName,
        decimal price, int quantityOnHand,
       int supplierId)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            QuantityOnHand = quantityOnHand;
            SupplierId = supplierId;
        }
        public override string ToString()
        {
            return $"{ProductId} - {ProductName} - {Price:C} - "
            + $"Qty: {QuantityOnHand} - ";
        }
    }


}
