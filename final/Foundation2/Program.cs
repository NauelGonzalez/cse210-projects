using System;

class Program
{
    static void Main(string[] args)
    {

        Customer cust1 = new Customer("Legolas", new Address("Path 6", "Northern Mirkwood", "Woodland Realm", "Middle Earth"));
        Customer cust2 = new Customer("Mickey Mouse", new Address("Cheese Av", "Mouseton", "Calisota", "USA"));


        List<Product> plist1 = new List<Product>();
        plist1.Add(new Product(1, "Bow", 400, 1));  // $400
        plist1.Add(new Product(2, "Arrow", 5, 100));  // $500
        plist1.Add(new Product(3, "Lembas Bread", 1, 25)); //$ 25
                                                // + 35 shipping outside USA 
                                                // Total = $960 


        List<Product> plist2 = new List<Product>();
        plist2.Add(new Product(4, "Cheese", 35, 3)); // $105
        plist2.Add(new Product(5, "Pants", 100, 1)); // $100
        plist2.Add(new Product(6, "whistle", 10, 2)); // $20
                                                    // +5 shipping withing USA
                                                    // Total = $230
        Order o1 = new Order(plist1, cust1);
        Order o2 = new Order(plist2, cust2);

        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"List of Items: \n{o1.GetPackingLabel()}");

        Console.WriteLine($"Total cost: ${o1.GetTotalPrice()}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"List of Items: \n{o2.GetPackingLabel()}");

        Console.WriteLine($"Total cost: ${o2.GetTotalPrice()}");


    }
}
