using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = products.Sum(p => p.CalculatePrice());
        decimal shippingCost = customer.Address.IsInUSA() ? 5m : 35m;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", products.Select(p => $"{p.Name} ({p.Id})"));
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}
