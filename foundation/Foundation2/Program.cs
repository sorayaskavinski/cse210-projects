using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("124 Main Street", "John Day", "OR","USA");
        Address address2 = new Address("Rua Jorge Candido Marin, 84", "Sao Bernardo do Campo","SP", "Brazil");
        Address address3 = new Address("24 S. University St.", "Los Angeles", "CA", "USA");

        Customer customer1 = new Customer("John Johnson", address1);
        Customer customer2 = new Customer("Fabio Costa", address2);
        Customer customer3 = new Customer("Mary Jane", address3);

        Product product1 = new Product("Computer","12345",257.75m,2);
        Product product2 = new Product("Mouse","5678",21.01m,10);
        Product product3 = new Product("Headset","245",15.00m,2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);

        Order order3 = new Order(customer3);
        order3.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():F2}\n");

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order3.CalculateTotalCost():F2}");
    }
}