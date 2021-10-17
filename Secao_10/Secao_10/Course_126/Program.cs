using System;
using Course_126.Entities;

namespace Course_126
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
