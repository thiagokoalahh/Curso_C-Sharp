using System;
using System.Globalization;

namespace Course_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(dolares, cot);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
