using System;
using System.Globalization;
using Course_123_Exec.Entities;
using Course_123_Exec.Entities.Enums;

namespace Course_123_Exec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            Order order = new Order(os, client);

            Console.WriteLine();
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, pPrice, new Product(pName, pPrice));
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order.ToString());

        }
    }
}
