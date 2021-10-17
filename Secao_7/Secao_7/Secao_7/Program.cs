using System;

namespace Course_87 {
    class Program {
        static void Main(string[] args) {
            double valor = double.Parse(Console.ReadLine());
            double desconto = (valor < 100.0) ? valor * 0.1 : valor * 0.05;

            Console.WriteLine("Desconto: " + desconto + "\nValor final: " + (valor-desconto));
        }
    }
}
