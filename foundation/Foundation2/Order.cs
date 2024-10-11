using System;
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order (Customer customer)
    {
        _products = new List<Product>();
        Customer _customer = customer;
    }
    public void AddProduct (Product product)
    {
        _products.Add(product);
    }
    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach(var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}