// See https://aka.ms/new-console-template for more information
using System;

namespace Odev
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 1;
            product1.name = "Phone";
            product1.price = 100;
            product1.quantity = 4;
            product1.description = "New generation phone";

            Product product2 = new Product();
            product2.productId = 2;
            product2.name = "Laptop";
            product2.price = 400;
            product2.quantity = 6;
            product2.description = "Asus computer";

            Product product3 = new Product();
            product3.productId = 3;
            product3.name = "Table";
            product3.price = 80;
            product3.quantity = 7;
            product3.description = "Dinner table";

            ProductManager productManager = new ProductManager();
            //productManager.Add(product1);
            //productManager.Add(product2);
            //productManager.Delete(product3);

            Product[] Products = new Product[] { product1, product2, product3 };

            foreach (var item in Products)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.price);
                Console.WriteLine(item.quantity);
                Console.WriteLine(item.description);
                Console.WriteLine("--------------");
            }

            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[i].name);
                Console.WriteLine(Products[i].price);
                Console.WriteLine(Products[i].quantity);
                Console.WriteLine(Products[i].description);
                Console.WriteLine("--------------");
            }

            int product = 0;
            while (product<Products.Length)
            {
                Console.WriteLine(Products[product].name);
                Console.WriteLine(Products[product].price);
                Console.WriteLine(Products[product].quantity);
                Console.WriteLine(Products[product].description);
                Console.WriteLine("--------------");
                product++;
            }


        }
    }
}
