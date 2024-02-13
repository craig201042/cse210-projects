using System;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        List<Product> pl1=new List<Product>();
        List<Customer> cl1=new List<Customer>();
        List<Product> pl2=new List<Product>();
        List<Customer> cl2=new List<Customer>();

        Product p1= new Product("Banana", "01001", 0.82, 2);
        Product p2= new Product("Instant Noodle", "02002", 0.6, 3);
        Product p3= new Product("Chips", "03003", 0.4, 4);
        Product p4= new Product("pot", "04004", 10, 1);
        Product p5= new Product("bike", "05005", 35, 1);
        Product p6= new Product("oven", "06006", 12, 1);

        Address a1= new Address("No.152, Millstone Rd.", "Houston", "Texas", "USA");
        Customer c1= new Customer("Frank", a1);
        Address a2= new Address("No.32, Zong Zeng Rd.", "Da-Li", "Taichung", "Taiwan");
        Customer C2=new Customer("Eva", a2);
        
        Order o1= new Order(pl1, cl1);
        Order o2= new Order(pl2, cl2);
    
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.AddCustomer(c1);

        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);
        o2.AddCustomer(C2);

        o1.packingLabel();
        o1.shippingLabel();
        Console.WriteLine($"total Price:${o1.totalPrice()}");

        o2.packingLabel();
        o2.shippingLabel();
        Console.WriteLine($"total Price:${o2.totalPrice()}");
    }
}