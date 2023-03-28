using System;

class Program
{
    static void Main(string[] args)
    {
        Customer Alex = new Customer("Alex Sandler", "21 Jump St", "California", "California", "U.S.A");
        Customer Joel = new Customer("Joel Mark Witt", "Sesame St", "Charlotte", "South Carolina", "U.S.A");
        Customer louane = new Customer("Louade De Merde", "Balanques St", "Marseille", "France-Sud", "France");

        Product berries = new Product("Berry", "b01", 50, 1);
        Product bananas = new Product("Bananas", "b02", 7, 12);
        Product captainCrunch = new Product("captain Crunch Cereals", "c01", 80, 1);
        Product darkChocolate = new Product("Dark Chocolate", "d01", 50, 1);
        Product whiteChocolate = new Product("White Chocolate", "w01", 50, 12);
        Product tacos = new Product("Tacos", "t01", 40, 1);
        Product icecream = new Product("iceCream", "i01", 20, 1);
        Product bread = new Product("Bread", "b03", 40, 1);
        Product donought = new Product("Donoughts", "d02", 15, 12);

        List<Product> alexProducts = new List<Product>();
        alexProducts.AddRange(new List<Product> { berries, bananas, bread });
        
        List<Product> joelProducts = new List<Product>();
        joelProducts.AddRange(new List<Product> { tacos, whiteChocolate, donought });

        List<Product> louaneProducts = new List<Product>();
        louaneProducts.AddRange(new List<Product> { captainCrunch, darkChocolate, icecream });

        Order alexOrder = new Order(Alex, alexProducts);
        Console.WriteLine("------------------------------");
        Console.WriteLine(alexOrder.GetShippingLable());
        Console.WriteLine(alexOrder.GetPackingLable());
        Console.WriteLine($"Shipping Cost = {alexOrder.GetShippingCost()}");
        Console.WriteLine($"Total Cost = {alexOrder.GetCost()}");

        Order joelOrder = new Order(Joel, joelProducts);
        Console.WriteLine("------------------------------");
        Console.WriteLine(joelOrder.GetShippingLable());
        Console.WriteLine(joelOrder.GetPackingLable());
        Console.WriteLine($"Shipping Cost = {joelOrder.GetShippingCost()}");
        Console.WriteLine($"Total Cost = {joelOrder.GetCost()}");

        Order louaneOrder = new Order(louane, louaneProducts);
        Console.WriteLine("------------------------------");
        Console.WriteLine(louaneOrder.GetShippingLable());
        Console.WriteLine(louaneOrder.GetPackingLable());
        Console.WriteLine($"Shipping Cost = {louaneOrder.GetShippingCost()}");
        Console.WriteLine($"Total Cost = {louaneOrder.GetCost()}");
        
        Console.WriteLine("------------------------------");
    }
}