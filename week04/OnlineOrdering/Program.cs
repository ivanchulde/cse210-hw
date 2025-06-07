using System;

class Program
{
    static void Main(string[] args)
    {
         // First Order
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Widget", "W001", 10.0, 2),
            new Product("Gadget", "G001", 15.5, 1)
        };

        Order order1 = new Order(products1, customer1);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        // Second Order
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Thingamajig", "T001", 20.0, 3),
            new Product("Doohickey", "D001", 5.0, 5)
        };

        Order order2 = new Order(products2, customer2);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
    
}