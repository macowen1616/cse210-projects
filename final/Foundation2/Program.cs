using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation2
{
    public class Product
    {
        private string name;
        private string productId;
        private double pricePerUnit;
        private int quantity;

        public Product(string name, string productId, double pricePerUnit, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.pricePerUnit = pricePerUnit;
            this.quantity = quantity;
        }

        public string GetName() => name;
        public string GetProductId() => productId;
        public double GetPricePerUnit() => pricePerUnit;
        public int GetQuantity() => quantity;

        public double GetTotalCost()
        {
            return pricePerUnit * quantity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address addr1 = new Address("123 Elm St", "Herosville", "NJ", "USA");
            Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

            Customer cust1 = new Customer("Mike Trout", addr1);
            Customer cust2 = new Customer("Makay Crandall", addr2);

            Product prod1 = new Product("Laptop", "LPT123", 999.99, 1);
            Product prod2 = new Product("Mouse", "MSE456", 25.50, 2);
            Product prod3 = new Product("Desk Chair", "CHR789", 150.00, 1);
            Product prod4 = new Product("Monitor", "MON321", 200.00, 2);
            Product prod5 = new Product("Keyboard", "KBD654", 75.00, 1);

            Order order1 = new Order(cust1);
            order1.AddProduct(prod1);
            order1.AddProduct(prod2);
            order1.AddProduct(prod3);

            Order order2 = new Order(cust2);
            order2.AddProduct(prod4);
            order2.AddProduct(prod5);

            Console.WriteLine("Order 1 Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());

            Console.WriteLine("Order 1 Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine($"Order 1 Total Price: ${order1.GetTotalPrice():0.00}\n");

            Console.WriteLine("Order 2 Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());

            Console.WriteLine("Order 2 Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());

            Console.WriteLine($"Order 2 Total Price: ${order2.GetTotalPrice():0.00}");
        }
    }
}
