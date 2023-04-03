using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1  = new Address("4549 E 250 N", "Rigby", "Idaho", "USA");
        Address address2  = new Address("150 King St W Suite 2108", "Toronto", "ON M5H 1J9", "Canada");

        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Berhnard Leif", address2);

        Product FirstProduct  = new Product("Cheese", 12345, 5.00, 2);
        Product SecondProduct  = new Product("Maple Syrup", 13254, 5.00, 2);
        Product ThirdProduct  = new Product("Pancake Mix", 15342, 10.00, 2);
        Product FourthProduct  = new Product("Bacon", 32145, 7.00, 2);
        Product FifthProduct  = new Product("Dosen Eggs", 14325, 12.00, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(FirstProduct);
        order1.AddProduct(FourthProduct);

        Order order2 = new Order(customer2);
        order2.AddProduct(SecondProduct);
        order2.AddProduct(ThirdProduct);

        // Display the results of these methods
        
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetTotalPrice());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetTotalPrice());
        Console.WriteLine(order2.GetPackingLabel());
    }
}