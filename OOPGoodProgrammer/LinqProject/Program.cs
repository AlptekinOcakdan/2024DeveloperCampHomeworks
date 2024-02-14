using System.Linq;
List<Category> categories = new List<Category>
{
    new Category { CategoryId = 1, CategoryName = "Beverages" },
    new Category { CategoryId = 2, CategoryName = "Condiments" },
    new Category { CategoryId = 3, CategoryName = "Confections" },
    new Category { CategoryId = 4, CategoryName = "Dairy Products" },
    new Category { CategoryId = 5, CategoryName = "Grains/Cereals" },
    new Category { CategoryId = 6, CategoryName = "Meat/Poultry" },
    new Category { CategoryId = 7, CategoryName = "Produce" },
    new Category { CategoryId = 8, CategoryName = "Seafood" }
};

List<Product> products = new List<Product>
{
    new Product() { ProductId = 1, CategoryId = 1, ProductName = "Chai", QuantityPerUnit = "10 boxes x 20 bags", UnitPrice = 18.00M, UnitsInStock = 39 },
    new Product() { ProductId = 2, CategoryId = 1, ProductName = "Chang", QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 19.00M, UnitsInStock = 17 },
    new Product() { ProductId = 3, CategoryId = 2, ProductName = "Aniseed Syrup", QuantityPerUnit = "12 - 550 ml bottles", UnitPrice = 10.00M, UnitsInStock = 13 },
    new Product() { ProductId = 4, CategoryId = 2, ProductName = "Chef Anton's Cajun Seasoning", QuantityPerUnit = "48 - 6 oz jars", UnitPrice = 22.00M, UnitsInStock = 53 },
    new Product() { ProductId = 5, CategoryId = 2, ProductName = "Chef Anton's Gumbo Mix", QuantityPerUnit = "36 boxes", UnitPrice = 21.35M, UnitsInStock = 0 },
    new Product() { ProductId = 6, CategoryId = 3, ProductName = "Grandma's Boysenberry Spread", QuantityPerUnit = "12 - 8 oz jars", UnitPrice = 25.00M, UnitsInStock = 120 },
    new Product() { ProductId = 7, CategoryId = 3, ProductName = "Uncle Bob's Organic Dried Pears", QuantityPerUnit = "12 - 1 lb pkgs.", UnitPrice = 30.00M, UnitsInStock = 15 },
    new Product() { ProductId = 8, CategoryId = 3, ProductName = "Northwoods Cranberry Sauce", QuantityPerUnit = "12 - 12 oz jars", UnitPrice = 40.00M, UnitsInStock = 6 },
    new Product() { ProductId = 9, CategoryId = 4, ProductName = "Mishi Kobe Niku", QuantityPerUnit = "18 - 500 g pkgs.", UnitPrice = 97.00M, UnitsInStock = 29 },
};

Console.WriteLine("Standart----------------------------------");

foreach (var product in products)
{
    if (product.UnitPrice>25)
    {
        Console.WriteLine(product.ProductName);
    }
}

Console.WriteLine("Linq----------------------------------");

var result = products.Where(p => p.UnitPrice > 25).Select(p => p.ProductName);
foreach (var product in result)
{
    Console.WriteLine(product);
}

Console.WriteLine("Method----------------------------------");

var result2 = getProducts(products);
foreach (var product in result2)
{
    Console.WriteLine(product.ProductName);
}

Console.WriteLine("Method Linq----------------------------------");

var result3 = getProductsLinq(products);
foreach (var product in result3)
{
    Console.WriteLine(product.ProductName);
}

static List<Product> getProducts(List<Product> products)
{
    List<Product> filteredProducts = new List<Product>();
    foreach (var product in products)
    {
        if (product.UnitPrice > 25)
        {
            filteredProducts.Add(product);
        }
    }
    return filteredProducts;
}

static List<Product> getProductsLinq(List<Product> products)
{
    return products.Where(p => p.UnitPrice > 25).ToList();
}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}