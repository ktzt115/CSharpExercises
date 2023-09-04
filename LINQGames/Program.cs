//Workbook 2, 4-13 Exercise 1
//Workbook 2, 4-19 Exercise 1
using Newtonsoft.Json;

namespace LINQGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Supplier> suppliers = new List<Supplier> { 
                new Supplier(101, "ACME", "acme.com"),
                new Supplier(201, "Spring Valley", "spring-valley.com"),
                new Supplier(301, "Winter Valley", "winter-valley.com"),
                new Supplier(401, "Silicon Valley", "silicon-valley.com")
            };

            List<Product> products = new List<Product> {
                new Product(1, "Dark Chocolate Bar", 4.99M, 10, 101),
                new Product(2, "8 oz Guacamole", 5.99M, 27, 201),
                new Product(3, "Milk Chocolate Bar", 3.99M, 16, 101),
                new Product(4, "8 pkg Chicken Tacos", 15.99M, 7, 201),
                new Product(5, "3 pkg Pork Tacos", 16.90M, 10, 201),
                new Product(6, "5 pkg Lamb Tacos", 32.93M, 15, 301),
                new Product(7, "7 pkg Beef Tacos", 32.00M, 20, 301),
                new Product(8, "10 pkg Chicken Dumplings", 10.99M, 9, 301),
                new Product(9, "11 pkg Chicken Burger", 12.39M, 1, 201),
                new Product(10, "37 pkg Chicken Nugget", 11.99M, 0, 401),
            };

            Console.WriteLine("Names of all suppliers");
            Console.WriteLine(string.Join(',', suppliers.Select(x=> x.Name)));

            Console.WriteLine("\n\nProducts with cost < $5");
            var cheapProducts = products.Where(x => x.Price <= 5);
            foreach (var product in cheapProducts)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\n\nProducts with low stock (less than 10)");

            var lowStockProducts = (from product in products
                                    where product.QuantityOnHand < 10
                                    orderby product.QuantityOnHand descending
                                    select product);

            foreach (var product in lowStockProducts)
            {
                Console.WriteLine(product);
            }

            var supplier201 = suppliers.FirstOrDefault(x => x.SupplierId == 201);
            if(supplier201 != null)
            {
                Console.WriteLine("\n\nInformation about Supplier 201");
                Console.WriteLine(supplier201);
            }

            Console.WriteLine("\n\nFirst Products that costs $5 or more");
            var notCheapProducts = products.Where(x => x.Price > 5);
            Console.WriteLine(notCheapProducts.FirstOrDefault());

            Console.WriteLine($"\n\n {cheapProducts.Count()} products cost $5 or less");

            var toReorder = GetItemsToBeReordered(products);

            Console.WriteLine("\n\nProducts to reorder");
            foreach (var product in toReorder)
            {
                Console.WriteLine(product);
            }

            var allInfos = from p in products
                           join s in suppliers
                           on p.SupplierId equals s.SupplierId
                           select new
                           {
                               p.ProductName,
                               p.Price,
                               SupplierName = s.Name
                           };

            Console.WriteLine();
            foreach(var info in allInfos)
            {
                Console.WriteLine(JsonConvert.SerializeObject(info));
            }

        }

        public static List<Product> GetItemsToBeReordered(List<Product> products)
        {
            return (from p in products where p.QuantityOnHand <=10 select p).ToList();
        }
    }
}