// See https://aka.ms/new-console-template for more information

using System.Linq;
var products = new List<Product>()
{
    new Product("BG-127"), new Product("WRTR-28"), new Product("GUAC-8")
};

Product? selectedProduct = null;
string continueInput = "y";
while (continueInput.ToLower().Equals("y"))
{
    string productCodeInput = "";
    int productChoice = 0;
    while (true)
    {
        Console.WriteLine("Please choose the following products. (1)  : BG-127 , (2) : WRTR-28 , (3) :  GUAC-8");
        productCodeInput = Console.ReadLine();
        if(int.TryParse(productCodeInput, out productChoice) && productChoice>0 && productChoice < 4)
        {
            selectedProduct = products[productChoice-1];
            break;
        }
        else
        {
            Console.WriteLine("Sorry. Please enter a valid product code.");
        }
    }

    while (true)
    {
        Console.WriteLine("Please enter quantity: ");
        string quantityInput = Console.ReadLine();
        if (int.TryParse(quantityInput, out int quantity))
        {
            selectedProduct.SetQuantity(quantity);
            break;
        }
        else
        {
            Console.WriteLine("Sorry. Please enter a valid quantity.");
        }
    }

    if (selectedProduct != null)
    {
        Console.WriteLine($"You have placed the following order!");
        Console.WriteLine($"Product Code: {selectedProduct.ProductCode}");
        Console.WriteLine($"Quantity :  {selectedProduct.GetQuantity()}");
        Console.WriteLine($"Per Unit Price for this order : {selectedProduct.GetUnitPrice()}");
        Console.WriteLine($"Total Order Price : {selectedProduct.GetTotalOrderPrice()}");
        if (selectedProduct.IsLargeOrder())
        {
            Console.WriteLine($"Wow. You have ordered very large amount! \n" +
                $"Congratulations! You are entitled for additional 15% discounted price!\n" +
                $"Your Final Discounted Price will be : {selectedProduct.GetLargeOrderDiscountedPrice()}");
        }
    }

    Console.WriteLine("Do you like to order new product? (y/n)");
    selectedProduct = null;
    continueInput = Console.ReadLine();
}




internal class Product
{
    public int MyProperty { get; private set; }
    public string ProductCode;
    private int _quantity;
    public Product(string productCode)
    {
        ProductCode = productCode;
        _quantity = 0;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetUnitPrice()
    {

        switch (ProductCode)
        {
            case "BG-127":
                return _quantity >= 51 ? 14.49 : _quantity >= 25 ? 17 : 18.99;
            case "WRTR-28":
                return _quantity >= 51 ? 99.99 : _quantity >= 25 ? 113.75 : 125.00;
            case "GUAC-8":
                return _quantity >= 51 ? 7.49 : 8.99;
            default: return 1;
        }
    }

    public double  GetTotalOrderPrice()
    {
        return _quantity * GetUnitPrice();
    }

    public bool IsLargeOrder()
    {
        return _quantity >= 250;
    }

    public double GetLargeOrderDiscountedPrice()
    {
        if (IsLargeOrder())
        {
            return GetTotalOrderPrice() * 0.85;
        }

        return GetTotalOrderPrice();
    }
}