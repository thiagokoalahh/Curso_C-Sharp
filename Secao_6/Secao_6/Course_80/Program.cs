using System;

namespace Course_80 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for(int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }

            Console.Write("\nNegative numbers: ");
            int negative = 0;
            foreach(int x in mat) {
                if (x < 0)
                    negative++;
            }

            Console.Write(negative);
        }
    }
}
