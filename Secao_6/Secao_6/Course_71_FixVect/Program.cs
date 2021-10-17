using System;

namespace Course_71_FixVect {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] quartos = new Estudante[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("\nAluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                quartos[room] = new Estudante(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine(i + ": " + quartos[i]);
                }
            }

        }
    }
}
