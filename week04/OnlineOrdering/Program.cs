using System;

class Program
{
    static void Main(string[] args)
    {

        
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Jose Vera", address1);
        Order order1 = new Order(customer1);
        

        order1.AddProduct(new Product("Gaming Laptop", "GL-9000", 1200.50, 1));
        order1.AddProduct(new Product("Wireless Mouse", "WM-04", 25.99, 2));


        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Smith", address2);
        Order order2 = new Order(customer2);
        
        order2.AddProduct(new Product("Mechanical Keyboard", "MK-85", 75.00, 1));
        order2.AddProduct(new Product("Monitor Stand", "MS-22", 30.00, 3));
        order2.AddProduct(new Product("USB-C Cable", "USB-10", 12.50, 2));



        Console.Clear();

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("               ORDER 1                ");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice():0.00}\n"); 

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("               ORDER 2                ");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice():0.00}\n");
    }
}