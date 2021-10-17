using System;

namespace Course_81_FixMat {
    class Program {
        static void Main(string[] args) {

            string[] vs = Console.ReadLine().Split(' ');
            int m = int.Parse(vs[0]);
            int n = int.Parse(vs[1]);

            int[,] table = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    table[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (table[i, j] == x) {
                        Console.WriteLine($"\nPosition ({i}, {j})");
                        if (i > 0) {
                            int up = table[i - 1, j];
                            Console.WriteLine("Up: " + up);
                        }
                        if (j > 0) {
                            int left = table[i, j - 1];
                            Console.WriteLine("Left: " + left);
                        }
                        if (j < n - 1) {
                            int right = table[i, j + 1];
                            Console.WriteLine("Right: " + right);
                        }
                        if (i < m - 1) {
                            int down = table[i + 1, j];
                            Console.WriteLine("Down: " + down);
                        }

                    }
                }
            }
        }
    }
}
