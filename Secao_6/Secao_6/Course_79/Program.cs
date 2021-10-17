using System;
using System.Collections;

namespace Course_79 {
    class Program {
        public static void Main(string[] args) {
            long n = int.Parse(Console.ReadLine());
            long[,] mat = new long[n,n];
            Random rand = new Random();

            for(long i = 0; i < n; i++) {
                Console.WriteLine();
                for(long j = 0; j < n; j++) {
                    mat[i, j] = rand.Next(-9, 9);
                    Console.Write(mat[i,j] + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
            long pos = 0, neg = 0, zero = 0;
            foreach(long x in mat) {
                if (x > 0)
                    pos++;
                else if (x < 0)
                    neg++;
                else
                    zero++;
            }
            Console.WriteLine("_____________________");
            Console.WriteLine($"Pos: {pos}\tNeg: {neg}\tZero: {zero}\tTotal: {mat.Length}");
        }
    }
}