using System;
using System.Globalization;
using Course_146.Entities;
using Course_146.Entities.Exceptions;

namespace Course_146
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new(number, holder, initialBalance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format exception: " + e.Message);
            }
        }
    }
}