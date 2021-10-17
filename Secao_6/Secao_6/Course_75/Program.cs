using System;

namespace Course_75 {
    class Program {
        static void Main(string[] args) {
            //boxing
            int x = 20;
            Object obj = x;
            //unboxing
            int y = (int) obj;

            int[] vect = new int[10];
            Random rand = new Random();
            for (int i = 0; i < vect.Length; i++) {
                vect[i] = rand.Next(0, 101);
            }

            foreach(int num in vect) {
                Console.WriteLine(num);
            }
        }
    }
}
