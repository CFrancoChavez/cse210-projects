using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Product 1", "P1", 10m, 2);
        Product product2 = new Product("Product 2", "P2", 5m, 3);
        Product product3 = new Product("Product 3", "P3", 20m, 1);

        // Create customers
        Address address1 = new Address("237 Main St", "Brooklyn", "NY", "USA");
        Customer customer1 = new Customer("Sarah Smith", address1);
        Address address2 = new Address("126 Oak St", "Alberta", "CA", "Canada");
        Customer customer2 = new Customer("Ethan Hawke", address2);

        // Create orders
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product2, product3, product1 }, customer2);

        // Display packing label, shipping label, and total cost for each order
        Console.WriteLine($"Order 1 packing label:\n{order1.GetPackingLabel()}\n");
        Console.WriteLine($"Order 1 shipping label:\n{order1.GetShippingLabel()}\n");
        Console.WriteLine($"Order 1 total cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine($"Order 2 packing label:\n{order2.GetPackingLabel()}\n");
        Console.WriteLine($"Order 2 shipping label:\n{order2.GetShippingLabel()}\n");
        Console.WriteLine($"Order 2 total cost: ${order2.CalculateTotalCost()}\n");

        Console.ReadLine();
    }
}
