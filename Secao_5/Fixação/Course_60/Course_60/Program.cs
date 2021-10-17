using System;
using System.Globalization;

namespace Course_60 {
    class Program {
        static void Main(string[] args) {
            Conta c1;
            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();
            
            if(resposta == "s") {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldoIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c1 = new Conta(num, name, saldoIni);
            }
            else {
                c1 = new Conta(num, name);
            }
            
            Console.WriteLine("\nDados da conta:\n" + c1);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:\n" + c1);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:\n" + c1);
        }
    }
}
