using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double productsTotal = 0;
        foreach (var product in products)
        {
            productsTotal += product.GetTotalCost();
        }
        double shippingCost = customer.IsInUSA() ? 5 : 35;
        return productsTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var product in products)
        {
            sb.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(customer.GetName());
        sb.AppendLine(customer.GetAddress().ToString());
        return sb.ToString();
    }
}
