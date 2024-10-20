using System;
public class Customer
{
    private string _name;
    private Address _customerAddress;
    public Customer (string name, Address customerAddress)
    {
        _name = name;
        _customerAddress = customerAddress;
    }
    public bool IsInUSA()
    {
        return _customerAddress.IsInUSA();
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _customerAddress;
    }
}