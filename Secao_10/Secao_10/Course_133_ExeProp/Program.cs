﻿using System;
using System.Globalization;
using System.Collections.Generic;
using Course_133_ExeProp.Entities;

namespace Course_133_ExeProp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used, or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'c') {
                    products.Add(new Product(name, price));
                }
                else if(type == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
