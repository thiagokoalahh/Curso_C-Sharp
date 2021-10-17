using System;

namespace Course_90 {
    class Program {
        static void Main(string[] args) {
            TimeSpan t1 = new TimeSpan(10, 0, 0);
            TimeSpan t2 = new TimeSpan(5, 0, 0);

            Console.WriteLine(t1 + " = " + t2);
            TimeSpan t3 = (t2 + t1);
            Console.WriteLine(t3);
        }
    }
}
