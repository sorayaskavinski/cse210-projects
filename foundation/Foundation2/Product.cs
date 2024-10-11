using System;
public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;
    public Product (string name, string productId, decimal price, int quantity)
    {
        string _name = name;
        string _productId = productId;
        decimal _price = price;
        int _quantity = quantity;
    }
    public decimal GetTotalCost ()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
}