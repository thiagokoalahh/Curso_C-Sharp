using System;
using System.Globalization;

namespace EX4_Estrutura_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();

        }

        static void Ex1()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Ex2()
        {
            int qtd = int.Parse(Console.ReadLine());
            int dentro = 0, fora = 0;

            for (int i = 0; i < qtd; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }

        static void Ex3()
        {
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                string[] val = Console.ReadLine().Split(' ');
                double n1 = double.Parse(val[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(val[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(val[2], CultureInfo.InvariantCulture);

                double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }

        static void Ex4()
        {
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                string[] val = Console.ReadLine().Split(' ');
                int n1 = int.Parse(val[0]);
                int n2 = int.Parse(val[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão impossível!");
                }
                else
                {
                    double div = (double)n1 / n2;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }

        static void Ex5()
        {
            int n = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 1; i <= n; i++)
            {
                fat *= i;
            }
            Console.WriteLine(fat);
        }

        static void Ex6()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Ex7()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int quad = (int)Math.Pow(i, 2);
                int cube = (int)Math.Pow(i, 3);

                Console.WriteLine($"{i} {quad} {cube}");
            }
        }
    }
}
