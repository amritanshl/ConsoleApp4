using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // 1. Basic Anonymous Type (The "Single" Object)
        var order = new
        {
            Id = 101,
            Product = "Laptop",
            Price = 85000.50
        };

        var aadhar = new
        {
            aadharnumber = 345678,
            name = "John Doe",
            Dateofbirth = Convert.ToDateTime("05-13/1996"),
            Gender="Male"
        };


        // 2. Complex Example with LINQ (The "List" Projection)
        var products = new List<Product>
        {
            new Product { Name = "Mouse", Category = "Electronics", Price = 500, Stock = 20 },
            new Product { Name = "Keyboard", Category = "Electronics", Price = 1200, Stock = 5 },
            new Product { Name = "Bottle", Category = "Lifestyle", Price = 300, Stock = 50 }
        };
       
    
        var stockSummary = products.Select(p => new {
            ItemName = p.Name,
            TotalValue = p.Price * p.Stock,
            IsLowStock = p.Stock < 10
        });

        Console.WriteLine($"Order ID: {order.Id} for {order.Product}");
        Console.WriteLine("--- Inventory Summary ---");

        foreach (var item in stockSummary)
        {
            string status = item.IsLowStock ? "REORDER!" : "OK";
            Console.WriteLine($"{item.ItemName} | Value: {item.TotalValue} | Status: {status}");
        }

        // 3. Type Checking
        Console.WriteLine($"\nInternal Type Name: {order.GetType().Name}");
    }
}

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}