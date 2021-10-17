using System;
using System.Globalization;

namespace EX1_Estrutura_Sequencial
{
    /*class Ex1
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("SOMA = " + (a+b));
        }
    }

    class Ex2
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double area = pi * (raio * raio);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }

    class Ex3
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int dif = (a * b) - (c * d);

            Console.WriteLine("DIFERENÇA = " + dif);

        }
    }

    class Ex4
    {
        static void Main(string[] args)
        {
            int numero, horas;
            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            double salhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salfinal = salhora * horas;

            Console.WriteLine("Number = " + numero);
            Console.WriteLine("SALARY = U$ " + salfinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class Ex5
    {
        static void Main(string[] args)
        {

            string[] vet1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet1[0]);
            int qtd1 = int.Parse(vet1[1]);
            double price1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int qtd2 = int.Parse(vet2[1]);
            double price2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valorTotal = (price1 * qtd1) + (price2 * qtd2);

            Console.WriteLine("Valor total a pagar: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }*/

    class Ex6
    {
        static void Main(string[] args)
        {

            double a, b, c, arTri, arCir, arTrap, arQuad, arRet;

            string[] val = Console.ReadLine().Split(' ');
            a = double.Parse(val[0], CultureInfo.InvariantCulture);
            b = double.Parse(val[1], CultureInfo.InvariantCulture);
            c = double.Parse(val[2], CultureInfo.InvariantCulture);

            arTri = (a * c) / 2;
            arCir = 3.14159 * c * c;
            arTrap = ((a + b) * c) / 2;
            arQuad = b * b;
            arRet = a * b;

            Console.WriteLine("TRIÂNGULO: " + arTri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + arCir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + arTrap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + arQuad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + arRet.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}


