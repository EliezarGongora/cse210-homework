using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("**************************************************");
        
        Address address1 = new Address ("Col. Santa Isabela #6 ", "Zacate", "LP", "El Salvador");
        Customer customer1 = new Customer("Eliezar", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Pupusas", "201", 0.75, 4);
        Product order1Product2 = new Product("Mangos", "4225", 0.50, 6);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        
        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);


        Console.WriteLine("**************************************************");


        
        Address address2 = new Address ("1234 Marshmellow Dr.", "Boise", "ID", "USA");
        Customer customer2 = new Customer("Kimberly", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Socks", "4260", 2.00, 5);
        Product order2Product2 = new Product("Nike Cortez", "4959", 100.00, 1);
        Product order2Product3 = new Product("Iphone 15", "4029", 1500.00, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();


        
        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("**************************************************");

    }   
}