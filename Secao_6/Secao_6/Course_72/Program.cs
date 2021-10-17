using System;

namespace Course_72 {
    class Program {
        static void Main(string[] args) {
            double s1 = Calculator.Sum(2.5, 3, 9);
            Console.WriteLine(s1);
            Console.WriteLine("");
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            Console.WriteLine("");

            int b = 5;
            Calculator.Triple(b, out int triple);
            Console.WriteLine(triple);

        }
    }
}
