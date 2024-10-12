using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Elizabeth Ferdinand", address1);
        Customer customer2 = new Customer("Paul Uche", address2);

        Product product1 = new Product("Laptop", "P1001", 999.99m, 1);
        Product product2 = new Product("Mouse", "P1002", 49.99m, 2);
        Product product3 = new Product("Keyboard", "P1003", 79.99m, 1);
        Product product4 = new Product("Monitor", "P1004", 199.99m, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }
    }
}