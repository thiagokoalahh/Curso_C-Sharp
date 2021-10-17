using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Ex1();
            Ex2();
            Ex3();
        }

        static void Ex1()
        {
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }

        static void Ex2()
        {
            string[] val = Console.ReadLine().Split();
            int x = int.Parse(val[0]);
            int y = int.Parse(val[1]);

            while (x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                val = Console.ReadLine().Split();
                x = int.Parse(val[0]);
                y = int.Parse(val[1]);

            }
        }

        static void Ex3()
        {
            int tipo = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool++;
                }
                else if (tipo == 2)
                {
                    gasolina++;
                }
                else if (tipo == 3)
                {
                    diesel++;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}