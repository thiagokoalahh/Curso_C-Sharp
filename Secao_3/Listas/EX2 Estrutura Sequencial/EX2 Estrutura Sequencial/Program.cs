using System;
using System.Globalization;

namespace EX2_Estrutura_Sequencial
{
    class Program
    {/*
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NÃO NEGATIVO");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }
        }
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');

            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);

            if(a%b==0||b%a==0)
                Console.WriteLine("SÃO MÚLTIPLOS");
            else
                Console.WriteLine("NÃO SÃO MÚLTIPLOS");
        }
        static void Main(string[] args)
        {
            string[] hora = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(hora[0]);
            int horaFinal = int.Parse(hora[1]);
            int tempo;

            if (horaInicial < horaFinal)
                tempo = horaFinal - horaInicial;
            else
                tempo = (24 - horaInicial) + horaFinal;

            Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");

        }
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                total = qtd * 4.00;
            }
            else if (codigo == 2)
            {
                total = qtd * 4.50;
            }
            else if (codigo == 3)
            {
                total = qtd * 5.00;
            }
            else if (codigo == 4)
            {
                total = qtd * 2.00;
            }
            else
            {
                total = qtd * 1.50;
            }

            Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
        
        static void Main(string[] args)
        {
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }

        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

        }*/
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resto = 0.0;

            double ir8, ir18, ir28;

            if (salario < 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario < 3000.00)
            {
                resto = salario - 2000.00;
                ir8 = resto * 0.08;
                Console.WriteLine("R$ " + ir8.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario < 4500.00)
            {
                ir8 = 80.00;
                resto = salario - 3000.00;
                ir18 = resto * 0.18;
                Console.WriteLine("R$ " + (ir8 + ir18).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                ir8 = 80.00;
                ir18 = 270.00;
                resto = salario - 4500.00;
                ir28 = resto * 0.28;
                Console.WriteLine("R$ " + (ir8 + ir18 + ir28).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
